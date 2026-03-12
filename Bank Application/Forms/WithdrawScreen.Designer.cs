namespace Bank_Application
{
    partial class WithdrawScreen
    {
        private void InitializeComponent()
        {
            AmountBox = new TextBox();
            AmountLabel = new Label();
            Withdraw = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(50, 130);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(250, 23);
            AmountBox.TabIndex = 0;
            // 
            // AmountLabel
            // 
            AmountLabel.Location = new Point(50, 100);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(100, 23);
            AmountLabel.TabIndex = 1;
            AmountLabel.Text = "Enter Amount:";
            // 
            // Withdraw
            // 
            Withdraw.Location = new Point(50, 200);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(250, 50);
            Withdraw.TabIndex = 2;
            Withdraw.Text = "CONFIRM WITHDRAW";
            Withdraw.Click += Withdraw_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(10, 10);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 3;
            btnHome.Text = "Back";
            btnHome.Click += btnHome_Click;
            // 
            // WithdrawScreen
            // 
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(AmountBox);
            Controls.Add(AmountLabel);
            Controls.Add(Withdraw);
            Controls.Add(btnHome);
            Name = "WithdrawScreen";
            this.FormClosing += this.WithdrawScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox AmountBox;
        private Label AmountLabel;
        private Button Withdraw, btnHome;
    }
}