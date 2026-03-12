namespace Bank_Application
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Register button wich transfers to Register Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegBut_Click(object sender, EventArgs e)
        {
            new RegScreen().Show();
            this.Hide();
        }

        /// <summary>
        /// Login Button wich transfers to Login Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogBut_Click(object sender, EventArgs e)
        {
            new LogScreen().Show();
            this.Hide();
        }

        /// <summary>
        /// Exit the Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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
