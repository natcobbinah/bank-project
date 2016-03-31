namespace BANK
{
    partial class Withdrawal_Form
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtaccnum = new System.Windows.Forms.TextBox();
            this.txtwithamount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Account Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Withdawal Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtaccnum
            // 
            this.txtaccnum.Location = new System.Drawing.Point(222, 79);
            this.txtaccnum.Name = "txtaccnum";
            this.txtaccnum.Size = new System.Drawing.Size(253, 20);
            this.txtaccnum.TabIndex = 1;
            this.txtaccnum.TextChanged += new System.EventHandler(this.txtaccnum_TextChanged);
            // 
            // txtwithamount
            // 
            this.txtwithamount.Location = new System.Drawing.Point(222, 138);
            this.txtwithamount.Multiline = true;
            this.txtwithamount.Name = "txtwithamount";
            this.txtwithamount.Size = new System.Drawing.Size(253, 36);
            this.txtwithamount.TabIndex = 1;
            this.txtwithamount.TextChanged += new System.EventHandler(this.txtwithamount_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Withdrawal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtwithamount);
            this.Controls.Add(this.txtaccnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Withdrawal_Form";
            this.Text = "Withdrawal_Form";
            this.Load += new System.EventHandler(this.Withdrawal_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaccnum;
        private System.Windows.Forms.TextBox txtwithamount;
        private System.Windows.Forms.Button button1;
    }
}