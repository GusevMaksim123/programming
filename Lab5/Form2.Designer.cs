﻿namespace WordsDictionary1
{
    partial class Form2
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
            this.pre2Text = new System.Windows.Forms.TextBox();
            this.korenText = new System.Windows.Forms.TextBox();
            this.suf1Text = new System.Windows.Forms.TextBox();
            this.suf2Text = new System.Windows.Forms.TextBox();
            this.pre1Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.konText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(393, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите слово в формате\r\n“пре  -  пре  -  [корень]  -  суф  -  суф  -  кон”";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pre2Text
            // 
            this.pre2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pre2Text.Location = new System.Drawing.Point(74, 57);
            this.pre2Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pre2Text.Name = "pre2Text";
            this.pre2Text.Size = new System.Drawing.Size(47, 23);
            this.pre2Text.TabIndex = 2;
            this.pre2Text.TextChanged += new System.EventHandler(this.pre2Text_TextChanged);
            // 
            // korenText
            // 
            this.korenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.korenText.Location = new System.Drawing.Point(136, 57);
            this.korenText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.korenText.Name = "korenText";
            this.korenText.Size = new System.Drawing.Size(47, 23);
            this.korenText.TabIndex = 3;
            this.korenText.TextChanged += new System.EventHandler(this.korenText_TextChanged);
            // 
            // suf1Text
            // 
            this.suf1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suf1Text.Location = new System.Drawing.Point(200, 57);
            this.suf1Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suf1Text.Name = "suf1Text";
            this.suf1Text.Size = new System.Drawing.Size(47, 23);
            this.suf1Text.TabIndex = 4;
            this.suf1Text.TextChanged += new System.EventHandler(this.suf1Text_TextChanged);
            // 
            // suf2Text
            // 
            this.suf2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suf2Text.Location = new System.Drawing.Point(262, 57);
            this.suf2Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suf2Text.Name = "suf2Text";
            this.suf2Text.Size = new System.Drawing.Size(47, 23);
            this.suf2Text.TabIndex = 5;
            this.suf2Text.TextChanged += new System.EventHandler(this.suf2Text_TextChanged);
            // 
            // pre1Text
            // 
            this.pre1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pre1Text.Location = new System.Drawing.Point(10, 57);
            this.pre1Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pre1Text.Name = "pre1Text";
            this.pre1Text.Size = new System.Drawing.Size(47, 23);
            this.pre1Text.TabIndex = 6;
            this.pre1Text.TextChanged += new System.EventHandler(this.pre1Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(163, 93);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 27);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // konText
            // 
            this.konText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.konText.Location = new System.Drawing.Point(326, 57);
            this.konText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.konText.Name = "konText";
            this.konText.Size = new System.Drawing.Size(47, 23);
            this.konText.TabIndex = 12;
            this.konText.TextChanged += new System.EventHandler(this.konText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 129);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.konText);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pre1Text);
            this.Controls.Add(this.suf2Text);
            this.Controls.Add(this.suf1Text);
            this.Controls.Add(this.korenText);
            this.Controls.Add(this.pre2Text);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pre2Text;
        private System.Windows.Forms.TextBox korenText;
        private System.Windows.Forms.TextBox suf1Text;
        private System.Windows.Forms.TextBox suf2Text;
        private System.Windows.Forms.TextBox pre1Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox konText;
        private System.Windows.Forms.Label label6;
    }
}