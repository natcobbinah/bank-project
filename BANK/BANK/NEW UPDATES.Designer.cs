﻿namespace BANK
{
    partial class NEW_UPDATES
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvtotalmoney = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Account With Most money";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Account with least Money";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "Total Money in Bank";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lvtotalmoney
            // 
            this.lvtotalmoney.GridLines = true;
            this.lvtotalmoney.Location = new System.Drawing.Point(234, 86);
            this.lvtotalmoney.Name = "lvtotalmoney";
            this.lvtotalmoney.Size = new System.Drawing.Size(501, 258);
            this.lvtotalmoney.TabIndex = 1;
            this.lvtotalmoney.UseCompatibleStateImageBehavior = false;
            this.lvtotalmoney.View = System.Windows.Forms.View.Details;
            // 
            // NEW_UPDATES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 416);
            this.Controls.Add(this.lvtotalmoney);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NEW_UPDATES";
            this.Text = "NEW_UPDATES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvtotalmoney;
    }
}