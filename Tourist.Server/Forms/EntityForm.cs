using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Enums;
using Tourist.Data.Shared;

namespace Tourist.Server.Forms
{
	public partial class EntityForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public EntityForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			SelectDefaultType( );
			EditButton.Enabled = false;
		}

		#endregion

		#region Private Methods

		private void EntitiesForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadEntityData( );
		}

		private void LoadEntityData( )
		{
			if ( Repository.IsEmpty( "Entity" ) )
				return;

			var entity = Repository.MData.Entity;
			LogoPictureBox.Image = SharedMethods.ByteArrayToImage( entity.LogoBuffer );
			NameTextBox.Text = entity.Name;
			TypeComboBox.Text = entity.EntityType.ToString( );
			NifTextBox.Text = entity.Nif.ToString( );
			AddressTextBox.Text = entity.Address;
			PhoneTextBox.Text = entity.Phone.ToString( );
			EmailTextBox.Text = entity.Email;

			ControlsToReadOnly( false );
		}

		private void SelectDefaultType( )
		{
			TypeComboBox.Text = TypeComboBox.Items[ 0 ].ToString( );
		}

		private void SaveEntityData( )
		{

			if ( LogoPictureBox.Image == null )
			{
				LogoPictureBox.Image = new Bitmap( Properties.Resources.NoImage );
			}

			var imageBuffer = SharedMethods.ImageToByteArray( LogoPictureBox.Image );
			var entityType = ( EntityType ) SharedMethods.ConvertStringToEnum( TypeComboBox.Text, "EntityType" );
			var entityName = NameTextBox.Text;
			var entityNif = Convert.ToInt32( NifTextBox.Text );
			var entityAddress = AddressTextBox.Text;
			var entityPhone = Convert.ToInt32( PhoneTextBox.Text );
			var entityEmail = EmailTextBox.Text;

			Repository.SetEntity( imageBuffer, entityType, entityName, entityNif,
																				entityAddress, entityPhone, entityEmail );
			Repository.Save( Repository.FileName );

			MessageBox.Show( this, Resources.Text.Strings.InformationSaved , Resources.Text.Strings.OperationSucessfull,
																		MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		private void ControlsToReadOnly( bool aBool )
		{
			NameTextBox.ReadOnly = aBool;
			TypeComboBox.Enabled = aBool;
			NifTextBox.ReadOnly = aBool;
			AddressTextBox.ReadOnly = aBool;
			PhoneTextBox.ReadOnly = aBool;
			EmailTextBox.ReadOnly = aBool;
			SaveButton.Enabled = aBool;
			EditButton.Enabled = !aBool;
			LogoPictureBox.Enabled = aBool;
		}

		#endregion

		#region Events

		private void LogoPictureBox_MouseClick( object sender, MouseEventArgs e )
		{
			LogoLoad.AddExtension = true;
			LogoLoad.Filter = Resources.Text.Strings.LogoFilter;
			LogoLoad.Title = Resources.Text.Strings.SaveLogoTitle;
			LogoLoad.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.Desktop );

			if ( LogoLoad.ShowDialog( ) == DialogResult.OK )
			{
				LogoPictureBox.Image = new Bitmap( LogoLoad.FileName );
			}
		}

		private void SaveButton_Click( object sender, EventArgs e )
		{
			if ( ValidateChildren( ValidationConstraints.Enabled ) )
			{
				SaveEntityData( );
				ControlsToReadOnly( false );
			}
		}

		private void EditButton_Click( object sender, EventArgs e )
		{
			ControlsToReadOnly( true );
		}

		private void NameTextBox_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			if ( string.IsNullOrEmpty( NameTextBox.Text ) )
			{
				e.Cancel = true;
				//NameTextBox.Focus();
				ErrorProvider.SetError( NameTextBox, Resources.Text.Strings.ErrorNameEmpty );
				ErrorProvider.SetIconPadding( NameTextBox, -25 );
			}
			else
			{
				e.Cancel = false;
				ErrorProvider.SetError( NameTextBox, "" );
			}
		}

		private void NifTextBox_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			if ( string.IsNullOrEmpty( NifTextBox.Text ) )
			{
				e.Cancel = true;
				//NifTextBox.Focus( );
				ErrorProvider.SetError( NifTextBox, Resources.Text.Strings.ErrorNIfEmpty );
				ErrorProvider.SetIconPadding( NifTextBox, -25 );
			}
			else if ( !SharedMethods.IsNumeric( NifTextBox.Text ) )
			{
				e.Cancel = true;
				//NifTextBox.Focus( );
				ErrorProvider.SetError( NifTextBox, Resources.Text.Strings.ErrorNifOnlyDigits );
				ErrorProvider.SetIconPadding( NifTextBox, -25 );
			}
			else if ( NifTextBox.Text.Length < 9 || NifTextBox.Text.Length > 9 )
			{
				e.Cancel = true;
				//NifTextBox.Focus( );
				ErrorProvider.SetError( NifTextBox, Resources.Text.Strings.ErrorNifNineDigits );
				ErrorProvider.SetIconPadding( NifTextBox, -25 );
			}
			else
			{
				e.Cancel = false;
				ErrorProvider.SetError( NifTextBox, "" );
			}
		}

		private void AddressTextBox_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			if ( string.IsNullOrEmpty( AddressTextBox.Text ) )
			{
				e.Cancel = true;
				//AddressTextBox.Focus( );
				ErrorProvider.SetError( AddressTextBox, Resources.Text.Strings.ErrorAddressEmpty );
				ErrorProvider.SetIconPadding( AddressTextBox, -25 );
			}
			else
			{
				e.Cancel = false;
				ErrorProvider.SetError( AddressTextBox, "" );
			}
		}

		private void PhoneTextBox_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			if ( string.IsNullOrEmpty( PhoneTextBox.Text ) )
			{
				e.Cancel = true;
				//PhoneTextBox.Focus( );
				ErrorProvider.SetError( PhoneTextBox, Resources.Text.Strings.ErrorPhoneEmpty );
				ErrorProvider.SetIconPadding( PhoneTextBox, -25 );
			}
			else if ( !SharedMethods.IsNumeric( PhoneTextBox.Text ) )
			{
				e.Cancel = true;
				//PhoneTextBox.Focus( );
				ErrorProvider.SetError( PhoneTextBox, Resources.Text.Strings.ErrorPhoneOnlyDigits );
				ErrorProvider.SetIconPadding( PhoneTextBox, -25 );
			}
			else
			{
				e.Cancel = false;
				ErrorProvider.SetError( PhoneTextBox, "" );
			}
		}

		private void EmailTextBox_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			if ( string.IsNullOrEmpty( EmailTextBox.Text ) )
			{
				e.Cancel = true;
				//EmailTextBox.Focus( );
				ErrorProvider.SetError( EmailTextBox, Resources.Text.Strings.ErrorEmailEmpty );
				ErrorProvider.SetIconPadding( EmailTextBox, -25 );
			}
			else if ( !SharedMethods.IsEmailValid( EmailTextBox.Text ) )
			{
				e.Cancel = true;
				//EmailTextBox.Focus( );
				ErrorProvider.SetError( EmailTextBox, Resources.Text.Strings.ErrorEmailNotValid );
				ErrorProvider.SetIconPadding( EmailTextBox, -25 );
			}
			else
			{
				e.Cancel = false;
				ErrorProvider.SetError( EmailTextBox, "" );
			}
		}

		#endregion

		#region Close Events

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Resources.Text.Strings.ExitMessage, Resources.Text.Strings.ExitMessageTitle
				, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			if ( !Repository.IsEmpty( "Entity" ) )
			{
				if ( Repository.IsEmpty( "Managers" ) )
				{
					mBackOrExit = true;
					Close( );

					var managerForm = new ManagersForm( mMainForm );
					managerForm.Show( );
				}
				else if ( !Repository.IsEmpty( "Managers" ) && Repository.IsEmpty( "Employees" ) )
				{
					mBackOrExit = true;
					Close( );

					var employersForm = new EmployersForm( mMainForm );
					employersForm.Show( );
				}
				else
				{
					mBackOrExit = true;
					Close( );

					mMainForm.Show( );
				}
			}
			else
			{
				MessageBox.Show( this, Resources.Text.Strings.InformationDataNotComplete,
								Resources.Text.Strings.DataEmptyOrNotComplete, MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		#endregion

	}
}
