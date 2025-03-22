namespace Banking_System0
{
    partial class WithdrawAmount
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
            txtAmount = new TextBox();
            btnWithdraw = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 96);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(377, 155);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(259, 31);
            txtAmount.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(377, 204);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(259, 34);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(524, 305);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // WithdrawAmount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 527);
            Controls.Add(btnBack);
            Controls.Add(btnWithdraw);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Name = "WithdrawAmount";
            Text = "Banking System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Button btnWithdraw;
        private Button btnBack;
    }
}