namespace BANK
{
    partial class Deposit_Form
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
            this.components = new System.ComponentModel.Container();
            this.labTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaccnum = new System.Windows.Forms.TextBox();
            this.txtdpamount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cboactype = new System.Windows.Forms.ComboBox();
            this.cbocusttype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(221, 27);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(30, 13);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "Date";
            this.labTime.Click += new System.EventHandler(this.labTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Deposit Amount";
            // 
            // txtaccnum
            // 
            this.txtaccnum.Location = new System.Drawing.Point(156, 98);
            this.txtaccnum.Name = "txtaccnum";
            this.txtaccnum.Size = new System.Drawing.Size(195, 20);
            this.txtaccnum.TabIndex = 1;
            // 
            // txtdpamount
            // 
            this.txtdpamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdpamount.Location = new System.Drawing.Point(156, 251);
            this.txtdpamount.Multiline = true;
            this.txtdpamount.Name = "txtdpamount";
            this.txtdpamount.Size = new System.Drawing.Size(177, 48);
            this.txtdpamount.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cboactype
            // 
            this.cboactype.FormattingEnabled = true;
            this.cboactype.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cboactype.Location = new System.Drawing.Point(156, 148);
            this.cboactype.Name = "cboactype";
            this.cboactype.Size = new System.Drawing.Size(195, 21);
            this.cboactype.TabIndex = 3;
            // 
            // cbocusttype
            // 
            this.cbocusttype.FormattingEnabled = true;
            this.cbocusttype.Items.AddRange(new object[] {
            "Student ",
            "Non-Student"});
            this.cbocusttype.Location = new System.Drawing.Point(156, 197);
            this.cbocusttype.Name = "cbocusttype";
            this.cbocusttype.Size = new System.Drawing.Size(195, 21);
            this.cbocusttype.TabIndex = 3;
            // 
            // Deposit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 381);
            this.Controls.Add(this.cbocusttype);
            this.Controls.Add(this.cboactype);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdpamount);
            this.Controls.Add(this.txtaccnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labTime);
            this.Name = "Deposit_Form";
            this.Text = "Deposit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaccnum;
        private System.Windows.Forms.TextBox txtdpamount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cboactype;
        private System.Windows.Forms.ComboBox cbocusttype;
    }
}