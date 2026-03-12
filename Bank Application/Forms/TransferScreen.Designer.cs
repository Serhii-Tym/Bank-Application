namespace Bank_Application
{
    partial class TransferScreen
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            NameBox = new TextBox();
            AmountBox = new TextBox();
            DescriptionBox = new TextBox();
            NameLabel = new Label();
            AmountLabel = new Label();
            DescritionLabel = new Label();
            btnSend = new Button();
            btnHome = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(50, 110);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(250, 23);
            NameBox.TabIndex = 0;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(50, 180);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(250, 23);
            AmountBox.TabIndex = 1;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(50, 250);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(250, 23);
            DescriptionBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(50, 80);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(100, 23);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Recipient Name:";
            // 
            // AmountLabel
            // 
            AmountLabel.Location = new Point(50, 150);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(100, 23);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount ($):";
            // 
            // DescritionLabel
            // 
            DescritionLabel.Location = new Point(50, 220);
            DescritionLabel.Name = "DescritionLabel";
            DescritionLabel.Size = new Size(100, 23);
            DescritionLabel.TabIndex = 5;
            DescritionLabel.Text = "Description:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(50, 320);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(250, 50);
            btnSend.TabIndex = 6;
            btnSend.Text = "SEND TRANSFER";
            btnSend.Click += btnSend_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(10, 10);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 7;
            btnHome.Text = "Back";
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // TransferScreen
            // 
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(NameBox);
            Controls.Add(AmountBox);
            Controls.Add(DescriptionBox);
            Controls.Add(NameLabel);
            Controls.Add(AmountLabel);
            Controls.Add(DescritionLabel);
            Controls.Add(btnSend);
            Controls.Add(btnHome);
            Name = "TransferScreen";
            this.FormClosing += this.TransferScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox NameBox, AmountBox, DescriptionBox;
        private Label NameLabel, AmountLabel, DescritionLabel, label2;
        private Button btnSend, btnHome;
    }
}