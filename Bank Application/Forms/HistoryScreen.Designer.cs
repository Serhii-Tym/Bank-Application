namespace Bank_Application
{
    partial class HistoryScreen
    {
        private void InitializeComponent()
        {
            listBoxHistory = new ListBox();
            btnHome = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxHistory
            // 
            listBoxHistory.BackColor = Color.White;
            listBoxHistory.ItemHeight = 15;
            listBoxHistory.Location = new Point(20, 100);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(310, 349);
            listBoxHistory.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(20, 480);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(310, 40);
            btnHome.TabIndex = 1;
            btnHome.Text = "Back to Menu";
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(250, 40);
            label1.TabIndex = 2;
            label1.Text = "Transaction History";
            // 
            // HistoryScreen
            // 
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(listBoxHistory);
            Controls.Add(btnHome);
            Controls.Add(label1);
            Name = "HistoryScreen";
            this.FormClosing += this.HistoryScreen_FormClosing;
            ResumeLayout(false);
        }
        private ListBox listBoxHistory;
        private Button btnHome;
        private Label label1;
    }
}