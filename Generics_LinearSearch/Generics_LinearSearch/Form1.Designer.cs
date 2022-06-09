namespace Generics_LinearSearch
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
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnDbl = new System.Windows.Forms.Button();
            this.ArrayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnInt
            // 
            this.BtnInt.Location = new System.Drawing.Point(37, 36);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(75, 34);
            this.BtnInt.TabIndex = 0;
            this.BtnInt.Text = "Generate Integer";
            this.BtnInt.UseVisualStyleBackColor = true;
            this.BtnInt.Click += new System.EventHandler(this.BtnInt_Click);
            // 
            // BtnDbl
            // 
            this.BtnDbl.Location = new System.Drawing.Point(171, 36);
            this.BtnDbl.Name = "BtnDbl";
            this.BtnDbl.Size = new System.Drawing.Size(75, 35);
            this.BtnDbl.TabIndex = 1;
            this.BtnDbl.Text = "Generate Double";
            this.BtnDbl.UseVisualStyleBackColor = true;
            this.BtnDbl.Click += new System.EventHandler(this.BtnDbl_Click);
            // 
            // ArrayBox
            // 
            this.ArrayBox.Location = new System.Drawing.Point(37, 99);
            this.ArrayBox.Multiline = true;
            this.ArrayBox.Name = "ArrayBox";
            this.ArrayBox.Size = new System.Drawing.Size(209, 133);
            this.ArrayBox.TabIndex = 2;
            this.ArrayBox.TextChanged += new System.EventHandler(this.ArrayBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number to Search For:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 262);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(75, 21);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(37, 298);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(119, 300);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(127, 20);
            this.ResultBox.TabIndex = 6;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 363);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrayBox);
            this.Controls.Add(this.BtnDbl);
            this.Controls.Add(this.BtnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInt;
        private System.Windows.Forms.Button BtnDbl;
        private System.Windows.Forms.TextBox ArrayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

