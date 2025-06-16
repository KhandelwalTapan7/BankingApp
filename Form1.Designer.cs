namespace BankingApp
{
    partial class Form1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPinPrompt = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNewPin = new System.Windows.Forms.Button();
            this.btnCheckPinStrength = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnViewMiniStatement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 60);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPinPrompt
            // 
            this.lblPinPrompt.AutoSize = true;
            this.lblPinPrompt.Location = new System.Drawing.Point(30, 90);
            this.lblPinPrompt.Name = "lblPinPrompt";
            this.lblPinPrompt.Size = new System.Drawing.Size(56, 13);
            this.lblPinPrompt.TabIndex = 4;
            this.lblPinPrompt.Text = "Enter PIN:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(100, 87);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(150, 20);
            this.txtPin.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNewPin
            // 
            this.btnNewPin.Location = new System.Drawing.Point(30, 30);
            this.btnNewPin.Name = "btnNewPin";
            this.btnNewPin.Size = new System.Drawing.Size(100, 30);
            this.btnNewPin.TabIndex = 7;
            this.btnNewPin.Text = "New PIN";
            this.btnNewPin.UseVisualStyleBackColor = true;
            this.btnNewPin.Visible = false;
            this.btnNewPin.Click += new System.EventHandler(this.btnNewPin_Click);
            // 
            // btnCheckPinStrength
            // 
            this.btnCheckPinStrength.Location = new System.Drawing.Point(150, 30);
            this.btnCheckPinStrength.Name = "btnCheckPinStrength";
            this.btnCheckPinStrength.Size = new System.Drawing.Size(100, 30);
            this.btnCheckPinStrength.TabIndex = 8;
            this.btnCheckPinStrength.Text = "Check PIN";
            this.btnCheckPinStrength.UseVisualStyleBackColor = true;
            this.btnCheckPinStrength.Visible = false;
            this.btnCheckPinStrength.Click += new System.EventHandler(this.btnCheckPinStrength_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(270, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(30, 70);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 30);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(150, 70);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 30);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(270, 70);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 30);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(30, 110);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(100, 30);
            this.btnCheckBalance.TabIndex = 13;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Visible = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnViewMiniStatement
            // 
            this.btnViewMiniStatement.Location = new System.Drawing.Point(150, 110);
            this.btnViewMiniStatement.Name = "btnViewMiniStatement";
            this.btnViewMiniStatement.Size = new System.Drawing.Size(100, 30);
            this.btnViewMiniStatement.TabIndex = 14;
            this.btnViewMiniStatement.Text = "Mini Statement";
            this.btnViewMiniStatement.UseVisualStyleBackColor = true;
            this.btnViewMiniStatement.Visible = false;
            this.btnViewMiniStatement.Click += new System.EventHandler(this.btnViewMiniStatement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnViewMiniStatement);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCheckPinStrength);
            this.Controls.Add(this.btnNewPin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPinPrompt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form1";
            this.Text = "Banking App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPinPrompt;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNewPin;
        private System.Windows.Forms.Button btnCheckPinStrength;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnViewMiniStatement;
    }
}