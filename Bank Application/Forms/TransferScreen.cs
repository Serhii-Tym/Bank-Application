using System;
using System.Linq;
using System.Windows.Forms;
using Bank_Application.Classes;
using Bank_Application.NewFolder;

namespace Bank_Application
{
    public partial class TransferScreen : Form
    {
        public TransferScreen() { InitializeComponent(); }

        /// <summary>
        /// Transfer to another existing account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string recipientName = NameBox.Text.Trim();

            if (decimal.TryParse(AmountBox.Text, out decimal amount) && amount > 0)
            {
                var senderUser = DataManager.CurrentUser;

                if (senderUser.Account.Balance < amount)
                {
                    MessageBox.Show("Not enought money on Balance!");
                    return;
                }

                var recipient = DataManager.Users.FirstOrDefault(u => u.Username.Equals(recipientName, StringComparison.OrdinalIgnoreCase));

                if (recipient != null)
                {
                    if (recipient.Username == senderUser.Username)
                    {
                        MessageBox.Show("You cant send money to yourself!");
                        return;
                    }

                    senderUser.Account.AddTransaction(amount, TransactionType.Expense, $"Transaction: {recipientName}");
                    recipient.Account.AddTransaction(amount, TransactionType.Income, $"From: {senderUser.Username}");

                    DataManager.Save();
                    MessageBox.Show($"Succeffully Transfered ${amount} to User {recipientName}!");

                    new Forms.MenuScreen().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User with that Username not found!");
                }
            }
            else
            {
                MessageBox.Show("Enter right Amount!");
            }
        }

        /// <summary>
        /// Back home page button
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
        private void TransferScreen_FormClosing(object sender, FormClosingEventArgs e)
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