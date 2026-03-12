namespace Bank_Application
{
    partial class RegScreen
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
            LogBut = new Button();
            LabelPass = new Label();
            LabelName = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // LogBut
            // 
            LogBut.Location = new Point(27, 394);
            LogBut.Name = "LogBut";
            LogBut.Size = new Size(290, 99);
            LogBut.TabIndex = 9;
            LogBut.Text = "Enter to Application";
            LogBut.UseVisualStyleBackColor = true;
            // 
            // LabelPass
            // 
            LabelPass.AutoSize = true;
            LabelPass.Font = new Font("Segoe UI", 18F);
            LabelPass.Location = new Point(17, 233);
            LabelPass.Name = "LabelPass";
            LabelPass.Size = new Size(321, 32);
            LabelPass.TabIndex = 8;
            LabelPass.Text = "Enter Your Account Password";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 18F);
            LabelName.Location = new Point(29, 80);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(288, 32);
            LabelName.TabIndex = 7;
            LabelName.Text = "Enter Your Account Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 5;
            // 
            // RegScreen
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
            Name = "RegScreen";
            Text = "RegScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogBut;
        private Label LabelPass;
        private Label LabelName;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}