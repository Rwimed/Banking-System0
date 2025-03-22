namespace Banking_System0
{
    partial class DepositAmount
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
            label2 = new Label();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 96);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Deposit Money";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 144);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(360, 208);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(319, 31);
            txtAmount.TabIndex = 2;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(360, 269);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(319, 34);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(567, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DepositAmount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDeposit);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepositAmount";
            Text = "Banking System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnBack;
    }
}