using Business;
using DataAccess;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        UserManager _userManager = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var checkEmail = _userManager.GetByEmail(email);
            if (checkEmail != null)
            {
                if (checkEmail.Email == email && checkEmail.Password == _userManager.PasswordHash(password))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Email or password is not correct");
                }

            }
            else
            {
                MessageBox.Show("Email or password is not correct");
            }


        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new ();
            registerScreen.Show();  
        }

     
    }
    
}