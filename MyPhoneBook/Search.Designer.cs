namespace MyPhoneBook
{
    partial class Search
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
            this.txt_serach = new System.Windows.Forms.TextBox();
            this.datagridViewSearch = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // txt_serach
            // 
            this.txt_serach.Location = new System.Drawing.Point(299, 57);
            this.txt_serach.Multiline = true;
            this.txt_serach.Name = "txt_serach";
            this.txt_serach.Size = new System.Drawing.Size(326, 41);
            this.txt_serach.TabIndex = 1;
            this.txt_serach.TextChanged += new System.EventHandler(this.txt_serach_TextChanged);
            // 
            // datagridViewSearch
            // 
            this.datagridViewSearch.AllowUserToAddRows = false;
            this.datagridViewSearch.AllowUserToDeleteRows = false;
            this.datagridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewSearch.ColumnHeadersVisible = false;
            this.datagridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Tell,
            this.Cell,
            this.Email,
            this.Address,
            this.Comment});
            this.datagridViewSearch.Location = new System.Drawing.Point(2, 121);
            this.datagridViewSearch.Name = "datagridViewSearch";
            this.datagridViewSearch.ReadOnly = true;
            this.datagridViewSearch.Size = new System.Drawing.Size(796, 317);
            this.datagridViewSearch.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Tell
            // 
            this.Tell.DataPropertyName = "Tell";
            this.Tell.HeaderText = "Tell";
            this.Tell.Name = "Tell";
            this.Tell.ReadOnly = true;
            // 
            // Cell
            // 
            this.Cell.DataPropertyName = "Cell";
            this.Cell.HeaderText = "Cell";
            this.Cell.Name = "Cell";
            this.Cell.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridViewSearch);
            this.Controls.Add(this.txt_serach);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_serach;
        private System.Windows.Forms.DataGridView datagridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}