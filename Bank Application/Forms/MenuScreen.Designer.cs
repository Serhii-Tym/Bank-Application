namespace Bank_Application.Forms
{
    partial class MenuScreen
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            lblBalance = new Label();
            lblSpent = new Label();
            lblDeposited = new Label();
            balanceCard = new Panel();
            MiniHistoryPanel = new FlowLayoutPanel();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnHome = new Button();
            btnHistory = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 48);
            label1.TabIndex = 1;
            label1.Text = "Your Balance";
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBalance.Location = new Point(20, 50);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(300, 50);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "0.00";
            // 
            // lblSpent
            // 
            lblSpent.Font = new Font("Segoe UI", 14F);
            lblSpent.ForeColor = Color.Tomato;
            lblSpent.Location = new Point(180, 110);
            lblSpent.Name = "lblSpent";
            lblSpent.Size = new Size(100, 23);
            lblSpent.TabIndex = 3;
            // 
            // lblDeposited
            // 
            lblDeposited.Font = new Font("Segoe UI", 14F);
            lblDeposited.ForeColor = Color.LightGreen;
            lblDeposited.Location = new Point(20, 110);
            lblDeposited.Name = "lblDeposited";
            lblDeposited.Size = new Size(100, 23);
            lblDeposited.TabIndex = 2;
            // 
            // balanceCard
            // 
            balanceCard.Location = new Point(0, 0);
            balanceCard.Name = "balanceCard";
            balanceCard.Size = new Size(200, 100);
            balanceCard.TabIndex = 0;
            // 
            // MiniHistoryPanel
            // 
            MiniHistoryPanel.BackColor = Color.White;
            MiniHistoryPanel.BorderStyle = BorderStyle.FixedSingle;
            MiniHistoryPanel.Location = new Point(20, 150);
            MiniHistoryPanel.Name = "MiniHistoryPanel";
            MiniHistoryPanel.Size = new Size(310, 203);
            MiniHistoryPanel.TabIndex = 4;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(80, 500);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(60, 40);
            btnDeposit.TabIndex = 6;
            btnDeposit.Text = "Transfer";
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(146, 500);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(68, 40);
            btnWithdraw.TabIndex = 7;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(10, 500);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(60, 40);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(220, 500);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(60, 40);
            btnHistory.TabIndex = 8;
            btnHistory.Text = "History";
            btnHistory.Click += btnHistory_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(290, 500);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(60, 40);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.Click += btnSettings_Click;
            // 
            // MenuScreen
            // 
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(lblBalance);
            Controls.Add(label1);
            Controls.Add(lblDeposited);
            Controls.Add(lblSpent);
            Controls.Add(MiniHistoryPanel);
            Controls.Add(btnHome);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnHistory);
            Controls.Add(btnSettings);
            Name = "MenuScreen";
            Text = "Dashboard";
            this.FormClosing += this.MenuScreen_FormClosing;
            ResumeLayout(false);
        }

        private Label label1, lblBalance, lblSpent, lblDeposited;
        private Panel balanceCard;
        private FlowLayoutPanel MiniHistoryPanel;
        private Button btnDeposit, btnWithdraw, btnHome, btnHistory, btnSettings;
    }
}