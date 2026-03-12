using System;
using System.Linq;
using System.Windows.Forms;
using Bank_Application.Classes;

namespace Bank_Application.Forms
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
            RefreshUI();
        }

        /// <summary>
        /// Balance view with Income and Expenses
        /// </summary>
        private void RefreshUI()
        {
            if (DataManager.CurrentUser == null) return;

            var acc = DataManager.CurrentUser.Account;
            lblBalance.Text = $"£{acc.Balance:F2}";

            decimal income = acc.Transitions.Where(t => t.Type == NewFolder.TransactionType.Income).Sum(t => t.Amount);
            decimal expense = acc.Transitions.Where(t => t.Type == NewFolder.TransactionType.Expense).Sum(t => t.Amount);

            lblDeposited.Text = $"+£{income:F2}";
            lblSpent.Text = $"-£{expense:F2}";

            MiniHistoryPanel.Controls.Clear();
            foreach (var t in acc.Transitions.AsEnumerable().Reverse().Take(3))
            {
                Label lbl = new Label { Text = t.ToString(), AutoSize = true, ForeColor = System.Drawing.Color.White };
                MiniHistoryPanel.Controls.Add(lbl);
            }
        }

        /// <summary>
        /// Low Bar buttons Transfering to another pages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeposit_Click(object sender, EventArgs e) => OpenForm(new TransferScreen());
        private void btnWithdraw_Click(object sender, EventArgs e) => OpenForm(new WithdrawScreen());
        private void btnHistory_Click(object sender, EventArgs e) => OpenForm(new HistoryScreen());
        private void btnSettings_Click(object sender, EventArgs e) => OpenForm(new SettingScreen());
        private void btnHome_Click(object sender, EventArgs e) => RefreshUI();

        /// <summary>
        /// Makes all the button transfer where they need to
        /// </summary>
        /// <param name="f"></param>
        private void OpenForm(Form f) { f.Show(); this.Hide(); }

        /// <summary>
        /// Exit the Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuScreen_FormClosing(object sender, FormClosingEventArgs e)
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