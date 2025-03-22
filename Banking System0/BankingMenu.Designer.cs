namespace Banking_System0
{
    partial class BankingMenu
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
            lblUser = new Label();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnCheckBalance = new Button();
            btnBack = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(508, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(217, 54);
            lblUser.TabIndex = 0;
            lblUser.Text = "Welcome,";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(481, 146);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(272, 34);
            btnDeposit.TabIndex = 1;
            btnDeposit.Text = "Deposit Money";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(481, 196);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(272, 34);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw Money";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnCheckBalance
            // 
            btnCheckBalance.Location = new Point(481, 247);
            btnCheckBalance.Name = "btnCheckBalance";
            btnCheckBalance.Size = new Size(272, 34);
            btnCheckBalance.TabIndex = 3;
            btnCheckBalance.Text = "Check Balance";
            btnCheckBalance.UseVisualStyleBackColor = true;
            btnCheckBalance.Click += btnCheckBalance_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(481, 393);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(272, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(481, 447);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(272, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BankingMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 523);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnCheckBalance);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(lblUser);
            Name = "BankingMenu";
            Text = "Banking System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnCheckBalance;
        private Button btnBack;
        private Button btnExit;
    }
}