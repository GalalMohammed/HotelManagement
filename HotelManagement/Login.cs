using Hotel_Manager.LOGIN_MANAGERModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifier("frontend".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    Hide();
                    Frontend hotel_management = new();
                    hotel_management.Show();
                }
                else if (verifier("kitchen".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    Hide();
                    Kitchen kitchen_management = new();
                    kitchen_management.Show();
                }
                else
                {
                    DialogResult res = MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Cancel)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                DialogResult res = MessageBox.Show(this, "An error occurred, try again", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Cancel)
                    Application.Exit();
                else
                    Application.Restart();
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
                usernameLabel.Visible = true;
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
                usernameLabel.Visible = false;
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
                passwordLabel.Visible = true;
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
                passwordLabel.Visible = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        public bool verifier(string tableName, string username, string password)
        {
            bool success = false;
            LOGIN_MANAGERContext login_Manager = new(new DbContextOptionsBuilder<LOGIN_MANAGERContext>().UseSqlServer(ConfigurationManager.ConnectionStrings["Hotel_Manager.Properties.Settings.loginConnectionString"].ConnectionString).Options);
            try
            {
                if (tableName == "frontend")
                {
                    var user = login_Manager.Frontends.AsNoTracking().FirstOrDefault(user => user.UserName == username && user.PassWord == password);
                    if (user != null)
                        success = true;
                }
                else if (tableName == "kitchen")
                {
                    var user = login_Manager.Kitchens.AsNoTracking().FirstOrDefault(user => user.UserName == username && user.PassWord == password);
                    if (user != null)
                        success = true;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
                DialogResult res = MessageBox.Show(this, "An error occurred, try again", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Cancel)
                    Application.Exit();
                else
                    Application.Restart();
            }
            finally
            {
                login_Manager.Dispose();
            }
            return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new();
            open_license.ShowDialog();
        }
    }
}
