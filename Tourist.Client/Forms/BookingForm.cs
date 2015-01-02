using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Client.Properties;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class BookingsForm : MetroForm
	{

		private readonly MainForm MainForm;
		private readonly IRemote Remote;
		private readonly BindingSource mNifsbBindingSource;
		private readonly BindingSource mSubTypesBindingSource;
		private readonly BindingSource mIdBindingSource;
		private bool mBackOrExit = default( bool );

		public BookingsForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );

			MainForm = aForm as MainForm;
			Remote = aRemote;
			EditButton.Enabled = false;
			mNifsbBindingSource = new BindingSource( );
			mSubTypesBindingSource = new BindingSource( );
			mIdBindingSource = new BindingSource( );
			EndDatePicker.Value = DateTime.Today.AddDays(1);

		}

		private void BookingsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );

			mNifsbBindingSource.DataSource = Remote.ClientsNifList( );
			NifComboBox.DataSource = mNifsbBindingSource;
		}

		private void AutoFillClientData( )
		{
			if ( string.IsNullOrEmpty( NifComboBox.Text ) ) return;

			var client = Remote.GetClientByNif( SharedMethods.ConvertStringToInt( NifComboBox.Text ) );
			ClientIdTextBox.Text = client.Id.ToString( );
			NameTextBox.Text = client.FirstName + " " + client.LastName;
		}

		private void LoadBookableSubTypes( )
		{
			if ( string.IsNullOrEmpty( TypeCombox.Text ) ) return;
			mSubTypesBindingSource.DataSource = Remote.BookableSubTypesList( TypeCombox.Text );
			SubTypeComboBox.DataSource = mSubTypesBindingSource;
		}

		private void LoadBookableIds( )
		{
			if ( string.IsNullOrEmpty( SubTypeComboBox.Text ) ) return;

			mIdBindingSource.DataSource = Remote.GetBooKablesIds( TypeCombox.Text, SubTypeComboBox.Text );
			BookableIdComboBox.DataSource = mIdBindingSource;

			BasePriceTextBox.Text = Remote.GetBasePrice( SubTypeComboBox.Text ).ToString( "0.00", CultureInfo.InvariantCulture );
		}

		private void LoadBookableDescription( )
		{
			if ( string.IsNullOrEmpty( BookableIdComboBox.Text ) ) return;

			DescriptionTextBox.Text = Remote.GetBookableDescription(
			SharedMethods.ConvertStringToInt( BookableIdComboBox.Text ), TypeCombox.Text );
		}

		private void NifComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			AutoFillClientData( );
		}

		#region Close Events

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Resources.ExitMessage,
				Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			MainForm.Show( );
		}

		#endregion

		private void NewClientButton_Click( object sender, EventArgs e )
		{
			mBackOrExit = true;
			Close( );
			var clientsForm = new ClientsForm( MainForm, Remote );
			clientsForm.Show( );
		}

		private void TypeCombox_SelectedValueChanged( object sender, EventArgs e )
		{
			LoadBookableSubTypes( );
		}

		private void SubTypeComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			LoadBookableIds( );
		}

		private void BookableIdComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			LoadBookableDescription( );
		}

		private void AddBooking( )
		{
			var booking = Remote.Factory.CreateObject<Booking>( );

			booking.Client = Remote.GetClientByNif( SharedMethods.ConvertStringToInt( NifComboBox.Text ) );
			booking.Bookable = Remote.GetBookable( TypeCombox.Text, SharedMethods.ConvertStringToInt( BookableIdComboBox.Text ) );
			booking.BookingDate = SharedMethods.ConvertStringToDateTime( BookingDateTextBox.Text );
			booking.TimeFrame = new DateTimeRange
			{
				StartDateTime = SharedMethods.ConvertStringToDateTime(StartDatePicker.Text),
				EndDateTime = SharedMethods.ConvertStringToDateTime( EndDatePicker.Text )
			};

			Remote.Append( booking, "Bookings" );

		}

		private void StartDatePicker_Validating( object sender, CancelEventArgs e )
		{
			BookingDateTextBox.Text = DateTime.Now.Date.ToString( "d" );
			BookingIdTextBox.Text = Remote.NextId( "Booking" ).ToString( );

			var timeframe = new DateTimeRange( );

			timeframe.StartDateTime = SharedMethods.ConvertStringToDateTime( StartDatePicker.Text );
			timeframe.EndDateTime = SharedMethods.ConvertStringToDateTime( EndDatePicker.Text );

			if ( timeframe.StartDateTime >= timeframe.EndDateTime )
			{
				e.Cancel = true;
				errorProvider.SetError( StartDatePicker, "The Start Date cannot be greater or equal than the End Date." );
				errorProvider.SetIconPadding( StartDatePicker, 10 );
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError( StartDatePicker, "" );
			}
		}

		private void EndDatePicker_Validating( object sender, CancelEventArgs e )
		{
			var timeframe = new DateTimeRange( );

			timeframe.StartDateTime = SharedMethods.ConvertStringToDateTime( StartDatePicker.Text );
			timeframe.EndDateTime = SharedMethods.ConvertStringToDateTime( EndDatePicker.Text );

			if ( timeframe.EndDateTime <= timeframe.StartDateTime )
			{
				e.Cancel = true;
				errorProvider.SetError( StartDatePicker, "The End Date cannot be less or equal than the Start Date." );
				errorProvider.SetIconPadding( StartDatePicker, 10 );
			}
			else
			{
				e.Cancel = false;
				errorProvider.SetError( StartDatePicker, "" );
			}

			TotalPriceLabel.Text = ( timeframe.DiferenceTimeSpan( ).Days * Remote.GetBasePrice( SubTypeComboBox.Text ) ).ToString( "0.00", CultureInfo.InvariantCulture );

		}

		private void SaveButton_Click( object sender, EventArgs e )
		{
			AddBooking( );
			MessageBox.Show( this, Resources.BookingString + Resources.AddString,
							Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );

			ControlsToReadOnly( true );
		}

		private void EditButton_Click( object sender, EventArgs e )
		{

		}

		private void ControlsToReadOnly( bool aBool )
		{
			NifComboBox.Enabled = aBool;
			TypeCombox.Enabled = aBool;
			SubTypeComboBox.Enabled = aBool;
			BookableIdComboBox.Enabled = aBool;
			StartDatePicker.Enabled = aBool;
			EndDatePicker.Enabled = aBool;
			SaveButton.Enabled = aBool;
			EditButton.Enabled = !aBool;
		}

		private void BookingIdTextBox_TextChanged( object sender, EventArgs e )
		{

		}


	}
}