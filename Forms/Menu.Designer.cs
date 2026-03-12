namespace Bank_Application
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegBut = new Button();
            LogBut = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // RegBut
            // 
            RegBut.Location = new Point(53, 225);
            RegBut.Name = "RegBut";
            RegBut.Size = new Size(283, 151);
            RegBut.TabIndex = 0;
            RegBut.Text = "Register Account";
            RegBut.UseVisualStyleBackColor = true;
            RegBut.Click += this.RegBut_Click;
            // 
            // LogBut
            // 
            LogBut.Location = new Point(468, 225);
            LogBut.Name = "LogBut";
            LogBut.Size = new Size(283, 151);
            LogBut.TabIndex = 1;
            LogBut.Text = "Login with Account";
            LogBut.UseVisualStyleBackColor = true;
            LogBut.Click += this.LogBut_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 26F);
            label.Location = new Point(138, 76);
            label.Name = "label";
            label.Size = new Size(539, 47);
            label.TabIndex = 2;
            label.Text = "Hello there, Choose an Operation";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(LogBut);
            Controls.Add(RegBut);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegBut;
        private Button LogBut;
        private Label label;
    }
}
