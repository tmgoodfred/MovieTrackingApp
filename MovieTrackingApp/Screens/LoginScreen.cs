using Microsoft.Extensions.Configuration;
using MovieTrackingApp.API_and_DB_Calls;
using MovieTrackingApp.Screens;

namespace MovieTrackingApp
{
    public partial class LoginScreen : Form
    {
        private readonly DBCalls _dbCalls;

        public LoginScreen()
        {
            InitializeComponent();

            _dbCalls = new DBCalls();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text; // Assuming you have a TextBox named usernameTxt
            string password = passwordTxt.Text; // Assuming you have a TextBox named passwordTxt

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_dbCalls.VerifyLogin(username, password))
            {
                // Login successful
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the MainScreen and close the LoginScreen
                MainScreen mainScreen = new MainScreen(_dbCalls, username); // Pass DBCalls instance and username
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountScreen createAccountScreen = new CreateAccountScreen();
            createAccountScreen.Show();
            this.Hide();
        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
