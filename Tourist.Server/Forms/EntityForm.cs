using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;
using Tourist.Server.Properties;

namespace Tourist.Server.Forms
{
	public partial class EntityForm : MetroForm
	{

		private readonly Repository repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );


		public EntityForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			TypeComboBox.Text = TypeComboBox.Items[ 0 ].ToString( );
			EditButton.Enabled = false;
		}

		private void EntitiesForm_Load( object sender, EventArgs e )
		{
			LoadEntityData( );
			SetFormFullScreen( );
		}

		private void SetFormFullScreen( )
		{
			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );

			FormBorderStyle = FormBorderStyle.None;
			Focus( );
		}

		private void LoadEntityData( )
		{
			var entity = repository.MData.Entity;

			LogoPictureBox.Image = Shared.ByteArrayToImage( entity.LogoBuffer );
			NameTextBox.Text = entity.Name;
			TypeComboBox.Text = entity.EntityType.ToString( );
			NifTextBox.Text = entity.Nif.ToString( );
			AddressTextBox.Text = entity.Address;
			PhoneTextBox.Text = entity.PhoneNumber.ToString( );
			EmailTextBox.Text = entity.Email;

			ControlsToReadOnly( false );
		}

		private void SaveEntityData( )
		{

			if ( LogoPictureBox.Image == null )
			{
				LogoPictureBox.Image = new Bitmap( Resources.NoImage );
			}

			var imageBuffer = Shared.ImageToByteArray( LogoPictureBox.Image );
			var entityType = ( EntityType ) Shared.ConvertStringToEnum( TypeComboBox.Text, "EntityType" );
			var entityName = NameTextBox.Text;
			var entityNif = Convert.ToInt32( NifTextBox.Text );
			var entityAddress = AddressTextBox.Text;
			var entityPhone = Convert.ToInt32( PhoneTextBox.Text );
			var entityEmail = EmailTextBox.Text;

			repository.SetEntity( imageBuffer, entityType, entityName, entityNif,
																				entityAddress, entityPhone, entityEmail );
			repository.Save( repository.FileName );

			MetroMessageBox.Show( this, "Entity Information saved with Sucess !!!", "Metro Title",
																		MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		private void LogoPictureBox_MouseClick( object sender, MouseEventArgs e )
		{
			LogoLoad.AddExtension = true;
			LogoLoad.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg";
			LogoLoad.Title = "Save Entity Logo";
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

		private void NameTextBox_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			if ( string.IsNullOrEmpty( NameTextBox.Text ) )
			{
				e.Cancel = true;
				//NameTextBox.Focus();
				ErrorProvider.SetError( NameTextBox, "Error the entity name field cant be empty." );
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
				ErrorProvider.SetError( NifTextBox, "Error the nif field cant be empty." );
				ErrorProvider.SetIconPadding( NifTextBox, -25 );
			}
			else if ( !Shared.IsNumeric( NifTextBox.Text ) )
			{
				e.Cancel = true;
				//NifTextBox.Focus( );
				ErrorProvider.SetError( NifTextBox, "Error the nif field is not valid." );
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
				ErrorProvider.SetError( AddressTextBox, "Error the address field cant be empty." );
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
				ErrorProvider.SetError( PhoneTextBox, "Error the phone field cant be empty." );
				ErrorProvider.SetIconPadding( PhoneTextBox, -25 );
			}
			else if ( !Shared.IsNumeric( PhoneTextBox.Text ) )
			{
				e.Cancel = true;
				//PhoneTextBox.Focus( );
				ErrorProvider.SetError( PhoneTextBox, "Error the phone field is not valid." );
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
				ErrorProvider.SetError( EmailTextBox, "Error the email field cant be empty." );
				ErrorProvider.SetIconPadding( EmailTextBox, -25 );
			}
			else if ( !Shared.IsEmailValid( EmailTextBox.Text ) )
			{
				e.Cancel = true;
				//EmailTextBox.Focus( );
				ErrorProvider.SetError( EmailTextBox, "Error the email field is not valid." );
				ErrorProvider.SetIconPadding( EmailTextBox, -25 );
			}
			else
			{
				e.Cancel = false;
				ErrorProvider.SetError( EmailTextBox, "" );
			}
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			if ( repository.IsEmpty( "Entity" ) )
			{
				if ( !repository.IsEmpty( "Managers" ) && !repository.IsEmpty( "Employees" ) )
				{
					mBackOrExit = true;
					Close( );

					var employersForm = new ManagersForm( mMainForm );
					employersForm.Show( );
				}
				else
				{
					mBackOrExit = true;
					Close( );

					mMainForm.Show( );
				}
			}
		}
	}
}
