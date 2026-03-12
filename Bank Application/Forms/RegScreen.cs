using System;
using System.Windows.Forms;
using Bank_Application.Classes;
using Bank_Application.NewFolder;

namespace Bank_Application
{
    public partial class RegScreen : Form
    {
        public RegScreen() { InitializeComponent(); }

        /// <summary>
        /// Register Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long!");
                return;
            }

            DataManager.Load();

            if (DataManager.Users.Exists(u => u.Username == textBox1.Text))
            {
                MessageBox.Show("User already exists!");
                return;
            }

            DataManager.Users.Add(new User(textBox1.Text, textBox2.Text));
            DataManager.Save();

            MessageBox.Show("Registration successful!");

            new Menu().Show();
            this.Hide();
        }

        /// <summary>
        /// Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        /// <summary>
        /// Exit the Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegScreen_FormClosing(object sender, FormClosingEventArgs e)
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