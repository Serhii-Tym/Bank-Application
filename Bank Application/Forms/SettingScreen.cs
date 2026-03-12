using System;
using System.Windows.Forms;
using Bank_Application.Classes;

namespace Bank_Application
{
    public partial class SettingScreen : Form
    {
        public SettingScreen()
        {
            InitializeComponent();
            AccountNameBox.Text = DataManager.CurrentUser.Username;
            PasswordBox.Text = DataManager.CurrentUser.Password;
        }

        /// <summary>
        /// Button to save changes with your account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AccountNameBox.Text) || PasswordBox.Text.Length < 8)
            {
                MessageBox.Show("Name cannot be empty and password must be at least 8 characters!");
                return;
            }

            DataManager.CurrentUser.Username = AccountNameBox.Text;
            DataManager.CurrentUser.Password = PasswordBox.Text;
            DataManager.Save();
            MessageBox.Show("Settings Updated!");
        }

        /// <summary>
        /// Button to go back to home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            new Forms.MenuScreen().Show();
            this.Hide();
        }

        /// <summary>
        /// Logout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DataManager.CurrentUser = null;
            new Menu().Show();
            this.Hide();
        }

        /// <summary>
        /// Button to delete account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == DataManager.CurrentUser.Password)
            {
                DialogResult result = MessageBox.Show("Are you absolutely sure? This action cannot be undone!",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataManager.Users.Remove(DataManager.CurrentUser);
                    DataManager.Save();
                    DataManager.CurrentUser = null;

                    MessageBox.Show("Account successfully deleted.");
                    new Menu().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect password! Deletion canceled.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exit the Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the program?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // stops the form from closing
                return;
            }
            Application.Exit();
        }
    }
}