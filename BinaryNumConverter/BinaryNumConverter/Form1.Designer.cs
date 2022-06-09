namespace BinaryNumConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.DecimalValBox = new System.Windows.Forms.TextBox();
            this.BinaryValBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decimal Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binary Value";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(49, 94);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.ConvertBtn.TabIndex = 2;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // DecimalValBox
            // 
            this.DecimalValBox.Location = new System.Drawing.Point(135, 22);
            this.DecimalValBox.Name = "DecimalValBox";
            this.DecimalValBox.Size = new System.Drawing.Size(100, 20);
            this.DecimalValBox.TabIndex = 3;
            this.DecimalValBox.TextChanged += new System.EventHandler(this.DecimalValBox_TextChanged);
            // 
            // BinaryValBox
            // 
            this.BinaryValBox.Location = new System.Drawing.Point(135, 62);
            this.BinaryValBox.Name = "BinaryValBox";
            this.BinaryValBox.Size = new System.Drawing.Size(100, 20);
            this.BinaryValBox.TabIndex = 4;
            this.BinaryValBox.TextChanged += new System.EventHandler(this.BinaryValBox_TextChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(159, 93);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 141);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.BinaryValBox);
            this.Controls.Add(this.DecimalValBox);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Binary Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TextBox DecimalValBox;
        private System.Windows.Forms.TextBox BinaryValBox;
        private System.Windows.Forms.Button ClearBtn;
    }
}

