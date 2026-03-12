using System;
using System.Linq;
using System.Windows.Forms;
using Bank_Application.Classes;

namespace Bank_Application
{
    public partial class HistoryScreen : Form
    {   
        public HistoryScreen()
        {
            InitializeComponent();
            LoadHistory();
        }

        /// <summary>
        /// History of balance
        /// </summary>
        private void LoadHistory()
        {
            listBoxHistory.Items.Clear();
            var acc = DataManager.CurrentUser.Account;
            foreach (var t in acc.Transitions.AsEnumerable().Reverse())
            {
                listBoxHistory.Items.Add(t.ToString());
            }
        }

        /// <summary>
        /// Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            new Forms.MenuScreen().Show();
            this.Hide();
        }

        /// <summary>
        /// Exit the Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryScreen_FormClosing(object sender, FormClosingEventArgs e)
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