namespace Bank_Application
{
    partial class LogScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LabelName = new Label();
            LabelPass = new Label();
            LogBut = new Button();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 274);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 18F);
            LabelName.Location = new Point(34, 76);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(288, 32);
            LabelName.TabIndex = 2;
            LabelName.Text = "Enter Your Account Name";
            // 
            // LabelPass
            // 
            LabelPass.AutoSize = true;
            LabelPass.Font = new Font("Segoe UI", 18F);
            LabelPass.Location = new Point(54, 219);
            LabelPass.Name = "LabelPass";
            LabelPass.Size = new Size(227, 32);
            LabelPass.TabIndex = 3;
            LabelPass.Text = "Enter Your Password";
            // 
            // LogBut
            // 
            LogBut.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LogBut.Location = new Point(32, 390);
            LogBut.Name = "LogBut";
            LogBut.Size = new Size(290, 99);
            LogBut.TabIndex = 4;
            LogBut.Text = "Enter to Application";
            LogBut.UseVisualStyleBackColor = true;
            LogBut.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(112, 45);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 10;
            label1.Text = "Login Page";
            // 
            // LogScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(LogBut);
            Controls.Add(LabelPass);
            Controls.Add(LabelName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LogScreen";
            Text = "LogScreen";
            this.FormClosing += this.LogScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Button LogBut;
        private Button btnBack;
        private Label label1;
    }
}