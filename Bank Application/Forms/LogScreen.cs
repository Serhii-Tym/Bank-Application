using System;
using System.Linq;
using System.Windows.Forms;
using Bank_Application.Classes;
using Bank_Application.Forms;

namespace Bank_Application
{
    public partial class LogScreen : Form
    {
        public LogScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login Button with cheking is account exist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DataManager.Load();

            string name = textBox1.Text;
            string pass = textBox2.Text;
            var user = DataManager.Users.FirstOrDefault(u => u.Username == name && u.Password == pass);

            if (user != null)
            {
                DataManager.CurrentUser = user;
                MenuScreen menu = new MenuScreen();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

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
        private void LogScreen_FormClosing(object sender, FormClosingEventArgs e)
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