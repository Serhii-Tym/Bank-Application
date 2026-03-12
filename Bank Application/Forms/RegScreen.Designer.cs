namespace Bank_Application
{
    partial class RegScreen
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LogBut = new Button();
            LabelPass = new Label();
            LabelName = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // LogBut
            // 
            LogBut.Location = new Point(27, 394);
            LogBut.Name = "LogBut";
            LogBut.Size = new Size(290, 99);
            LogBut.TabIndex = 9;
            LogBut.Text = "Register Account";
            LogBut.UseVisualStyleBackColor = true;
            LogBut.Click += LogBut_Click;
            // 
            // LabelPass
            // 
            LabelPass.AutoSize = true;
            LabelPass.Font = new Font("Segoe UI", 18F);
            LabelPass.Location = new Point(29, 230);
            LabelPass.Name = "LabelPass";
            LabelPass.Size = new Size(227, 32);
            LabelPass.TabIndex = 10;
            LabelPass.Text = "Enter Your Password";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 18F);
            LabelName.Location = new Point(29, 80);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(288, 32);
            LabelName.TabIndex = 11;
            LabelName.Text = "Enter Your Account Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 278);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 13;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(102, 49);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 15;
            label1.Text = "Register Page";
            // 
            // RegScreen
            // 
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(LogBut);
            Controls.Add(LabelPass);
            Controls.Add(LabelName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegScreen";
            Text = "Registration";
            this.FormClosing += this.RegScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button LogBut;
        private Label LabelPass;
        private Label LabelName;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnBack;
        private Label label1;
    }
}