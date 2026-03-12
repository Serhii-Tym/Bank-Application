namespace Bank_Application
{
    partial class LogScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LabelName = new Label();
            LabelPass = new Label();
            LogBut = new Button();
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
            LabelPass.Location = new Point(22, 229);
            LabelPass.Name = "LabelPass";
            LabelPass.Size = new Size(321, 32);
            LabelPass.TabIndex = 3;
            LabelPass.Text = "Enter Your Account Password";
            // 
            // LogBut
            // 
            LogBut.Location = new Point(32, 390);
            LogBut.Name = "LogBut";
            LogBut.Size = new Size(290, 99);
            LogBut.TabIndex = 4;
            LogBut.Text = "Enter to Application";
            LogBut.UseVisualStyleBackColor = true;
            LogBut.Click += button1_Click;
            // 
            // LogScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(LogBut);
            Controls.Add(LabelPass);
            Controls.Add(LabelName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LogScreen";
            Text = "LogScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label LabelName;
        private Label LabelPass;
        private Button LogBut;
    }
}