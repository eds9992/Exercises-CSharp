namespace BankApp
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
            this.AccountLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BalanceextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Location = new System.Drawing.Point(43, 41);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(47, 13);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "Account";
            this.AccountLabel.Click += new System.EventHandler(this.AccountLabel_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(43, 93);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(43, 149);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(43, 199);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 3;
            this.BalanceLabel.Text = "Balance";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(109, 38);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(163, 20);
            this.accountTextBox.TabIndex = 4;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(109, 90);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(109, 146);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // BalanceextBox
            // 
            this.BalanceextBox.Location = new System.Drawing.Point(109, 196);
            this.BalanceextBox.Name = "BalanceextBox";
            this.BalanceextBox.Size = new System.Drawing.Size(163, 20);
            this.BalanceextBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(46, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save As";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BalanceextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AccountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox BalanceextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

