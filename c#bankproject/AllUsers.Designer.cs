namespace BANK
{
    partial class AllUsers
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
            this.lvallusers = new System.Windows.Forms.ListView();
            this.Surname = new System.Windows.Forms.Label();
            this.txtSearchuser = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvallusers
            // 
            this.lvallusers.GridLines = true;
            this.lvallusers.Location = new System.Drawing.Point(48, 84);
            this.lvallusers.Name = "lvallusers";
            this.lvallusers.Size = new System.Drawing.Size(961, 428);
            this.lvallusers.TabIndex = 0;
            this.lvallusers.UseCompatibleStateImageBehavior = false;
            this.lvallusers.View = System.Windows.Forms.View.Details;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(627, 33);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(74, 20);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Surname";
            // 
            // txtSearchuser
            // 
            this.txtSearchuser.Location = new System.Drawing.Point(719, 35);
            this.txtSearchuser.Name = "txtSearchuser";
            this.txtSearchuser.Size = new System.Drawing.Size(196, 20);
            this.txtSearchuser.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(934, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(75, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 555);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSearchuser);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.lvallusers);
            this.Name = "AllUsers";
            this.Text = "AllUsers";
            this.Load += new System.EventHandler(this.AllUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvallusers;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox txtSearchuser;
        private System.Windows.Forms.Button txtSearch;
    }
}