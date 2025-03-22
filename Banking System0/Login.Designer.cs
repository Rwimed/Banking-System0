namespace Banking_System0
{
    partial class Login
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
            label1 = new Label();
            txtUserName = new TextBox();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            btnExit = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 41);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(434, 144);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter your Username";
            txtUserName.Size = new Size(316, 31);
            txtUserName.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(434, 200);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.PlaceholderText = "Please enter your password";
            txtLoginPassword.Size = new Size(316, 31);
            txtLoginPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(434, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(316, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(434, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(316, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Create Account";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(434, 439);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(316, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(578, 99);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 526);
            Controls.Add(lblStatus);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "Login";
            Text = "Banking System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private Button btnBack;
        private Button btnExit;
        private Label lblStatus;
    }
}