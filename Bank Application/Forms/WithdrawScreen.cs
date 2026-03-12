using System;
using System.Windows.Forms;
using Bank_Application.Classes;

namespace Bank_Application
{
    public partial class WithdrawScreen : Form
    {
        public WithdrawScreen() { InitializeComponent(); }

        /// <summary>
        /// Simple Withdraw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountBox.Text, out decimal amount) && amount > 0)
            {
                var acc = DataManager.CurrentUser.Account;
                if (acc.Balance >= amount)
                {
                    acc.AddTransaction(amount, NewFolder.TransactionType.Expense, "ATM Withdrawal");
                    DataManager.Save();
                    MessageBox.Show("Withdrawal successful!");
                    new Forms.MenuScreen().Show();
                    this.Close();
                }
                else MessageBox.Show("Insufficient funds!");
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
        private void WithdrawScreen_FormClosing(object sender, FormClosingEventArgs e)
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