namespace Bank_Application
{
    partial class SettingScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            AccountNameBox = new TextBox();
            PasswordBox = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnHome = new Button();
            btnLogout = new Button();
            labelName = new Label();
            labelPass = new Label();
            labelConfirm = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AccountNameBox
            // 
            AccountNameBox.Location = new Point(50, 80);
            AccountNameBox.Name = "AccountNameBox";
            AccountNameBox.Size = new Size(250, 23);
            AccountNameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(50, 140);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(250, 23);
            PasswordBox.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(50, 367);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(250, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(50, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Changes";
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(50, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE ACCOUNT";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(10, 10);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.Font = new Font("Segoe UI", 14F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(50, 230);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // labelName
            // 
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 23);
            labelName.TabIndex = 0;
            // 
            // labelPass
            // 
            labelPass.Location = new Point(0, 0);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(100, 23);
            labelPass.TabIndex = 0;
            // 
            // labelConfirm
            // 
            labelConfirm.Font = new Font("Segoe UI", 14F);
            labelConfirm.ForeColor = Color.White;
            labelConfirm.Location = new Point(50, 332);
            labelConfirm.Name = "labelConfirm";
            labelConfirm.Size = new Size(250, 32);
            labelConfirm.TabIndex = 7;
            labelConfirm.Text = "Confirm password to delete account:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 8;
            label1.Text = "Change Username";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 106);
            label2.Name = "label2";
            label2.Size = new Size(250, 32);
            label2.TabIndex = 9;
            label2.Text = "Change Password";
            // 
            // SettingScreen
            // 
            BackColor = Color.FromArgb(69, 146, 140);
            ClientSize = new Size(355, 572);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AccountNameBox);
            Controls.Add(PasswordBox);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnHome);
            Controls.Add(btnLogout);
            Controls.Add(labelConfirm);
            Name = "SettingScreen";
            Text = "Account Settings";
            this.FormClosing += this.SettingScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox AccountNameBox;
        private TextBox PasswordBox;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnDelete;
        private Button btnHome;
        private Button btnLogout;
        private Label labelName;
        private Label labelPass;
        private Label labelConfirm;
        private Label label1;
        private Label label2;
    }
}