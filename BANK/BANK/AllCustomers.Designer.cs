namespace BANK
{
    partial class AllCustomers
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
            this.lvallcustomers = new System.Windows.Forms.ListView();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.Su = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvallcustomers
            // 
            this.lvallcustomers.GridLines = true;
            this.lvallcustomers.Location = new System.Drawing.Point(41, 77);
            this.lvallcustomers.Name = "lvallcustomers";
            this.lvallcustomers.Size = new System.Drawing.Size(945, 447);
            this.lvallcustomers.TabIndex = 0;
            this.lvallcustomers.UseCompatibleStateImageBehavior = false;
            this.lvallcustomers.View = System.Windows.Forms.View.Details;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(666, 32);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(239, 20);
            this.txtSearchCustomer.TabIndex = 1;
            // 
            // Su
            // 
            this.Su.AutoSize = true;
            this.Su.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su.Location = new System.Drawing.Point(547, 26);
            this.Su.Name = "Su";
            this.Su.Size = new System.Drawing.Size(98, 25);
            this.Su.TabIndex = 2;
            this.Su.Text = "Surname";
            this.Su.Click += new System.EventHandler(this.Su_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(911, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 564);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Su);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.lvallcustomers);
            this.Name = "AllCustomers";
            this.Text = " View All Customers";
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvallcustomers;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label Su;
        private System.Windows.Forms.Button btnSearch;
    }
}