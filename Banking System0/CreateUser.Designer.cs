namespace Banking_System0
{
    partial class CreateUser
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
            txtFullName = new TextBox();
            lblCreateUser = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtInitialDeposit = new TextBox();
            btnCreateUser = new Button();
            btnGoToLogin = new Button();
            btnExit = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(346, 117);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Please enter your full name";
            txtFullName.Size = new Size(357, 31);
            txtFullName.TabIndex = 0;
            // 
            // lblCreateUser
            // 
            lblCreateUser.AutoSize = true;
            lblCreateUser.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateUser.Location = new Point(444, 70);
            lblCreateUser.Name = "lblCreateUser";
            lblCreateUser.Size = new Size(170, 25);
            lblCreateUser.TabIndex = 1;
            lblCreateUser.Text = "Create a new User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(379, 26);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 2;
            label1.Text = "Welcome to our Banking System";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(346, 162);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Please enter your username";
            txtUsername.Size = new Size(357, 31);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(346, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Please enter a password";
            txtPassword.Size = new Size(357, 31);
            txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(346, 256);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Please confirm the password";
            txtConfirmPassword.Size = new Size(357, 31);
            txtConfirmPassword.TabIndex = 5;
            // 
            // txtInitialDeposit
            // 
            txtInitialDeposit.Location = new Point(346, 305);
            txtInitialDeposit.Name = "txtInitialDeposit";
            txtInitialDeposit.PlaceholderText = "Please enter your initial deposit (optional)";
            txtInitialDeposit.Size = new Size(357, 31);
            txtInitialDeposit.TabIndex = 6;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(346, 368);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(357, 34);
            btnCreateUser.TabIndex = 7;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click_1;
            // 
            // btnGoToLogin
            // 
            btnGoToLogin.Location = new Point(346, 419);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(357, 34);
            btnGoToLogin.TabIndex = 8;
            btnGoToLogin.Text = "Already have an account? Login";
            btnGoToLogin.UseVisualStyleBackColor = true;
            btnGoToLogin.Click += btnGoToLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(346, 473);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(357, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(346, 89);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 0;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 596);
            Controls.Add(lblStatus);
            Controls.Add(btnExit);
            Controls.Add(btnGoToLogin);
            Controls.Add(btnCreateUser);
            Controls.Add(txtInitialDeposit);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(lblCreateUser);
            Controls.Add(txtFullName);
            Name = "CreateUser";
            Text = "Banking System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Label lblCreateUser;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtInitialDeposit;
        private Button btnCreateUser;
        private Button btnGoToLogin;
        private Button btnExit;
        private Label lblStatus;
    }
}