namespace MyPhoneBook
{
    partial class Reg_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Data));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Add_New = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.comm_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adres_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cell_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ln_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fn_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.toolStrip1.SuspendLayout();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.Add_New,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1204, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // Add_New
            // 
            this.Add_New.Image = ((System.Drawing.Image)(resources.GetObject("Add_New.Image")));
            this.Add_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_New.Name = "Add_New";
            this.Add_New.Size = new System.Drawing.Size(110, 68);
            this.Add_New.Text = "New Data";
            this.Add_New.Click += new System.EventHandler(this.Add_New_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 68);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.toolStrip2);
            this.GroupBox.Controls.Add(this.comm_txt);
            this.GroupBox.Controls.Add(this.label8);
            this.GroupBox.Controls.Add(this.adres_txt);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.email_txt);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.cell_txt);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.tel_txt);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.ln_txt);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.fn_txt);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox.Location = new System.Drawing.Point(12, 81);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(441, 457);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Enter the Information";
            this.GroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comm_txt
            // 
            this.comm_txt.Location = new System.Drawing.Point(135, 325);
            this.comm_txt.Multiline = true;
            this.comm_txt.Name = "comm_txt";
            this.comm_txt.Size = new System.Drawing.Size(296, 72);
            this.comm_txt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Comment";
            // 
            // adres_txt
            // 
            this.adres_txt.Location = new System.Drawing.Point(135, 278);
            this.adres_txt.Multiline = true;
            this.adres_txt.Name = "adres_txt";
            this.adres_txt.Size = new System.Drawing.Size(193, 33);
            this.adres_txt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(135, 225);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(193, 33);
            this.email_txt.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // cell_txt
            // 
            this.cell_txt.Location = new System.Drawing.Point(135, 173);
            this.cell_txt.Multiline = true;
            this.cell_txt.Name = "cell_txt";
            this.cell_txt.Size = new System.Drawing.Size(193, 33);
            this.cell_txt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cell";
            // 
            // tel_txt
            // 
            this.tel_txt.Location = new System.Drawing.Point(135, 119);
            this.tel_txt.Multiline = true;
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(193, 33);
            this.tel_txt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tel";
            // 
            // ln_txt
            // 
            this.ln_txt.Location = new System.Drawing.Point(135, 67);
            this.ln_txt.Multiline = true;
            this.ln_txt.Name = "ln_txt";
            this.ln_txt.Size = new System.Drawing.Size(193, 33);
            this.ln_txt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "LastName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fn_txt
            // 
            this.fn_txt.Location = new System.Drawing.Point(135, 19);
            this.fn_txt.Multiline = true;
            this.fn_txt.Name = "fn_txt";
            this.fn_txt.Size = new System.Drawing.Size(193, 33);
            this.fn_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 446);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 400);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(435, 54);
            this.toolStrip2.TabIndex = 24;
            this.toolStrip2.Text = "toolStrip2";
            
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 1, 190, 1);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(83, 52);
            this.toolStripButton2.Text = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.fn_txt;
            this.requiredFieldValidator1.ErrorMessage = "PLs fill the  blank";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.ln_txt;
            this.requiredFieldValidator2.ErrorMessage = "Pls Fill the blank";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.email_txt;
            this.requiredFieldValidator3.ErrorMessage = "Pls Fill the Blank";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // Reg_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1204, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reg_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reg_Data";
            this.Load += new System.EventHandler(this.Reg_Data_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Add_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox comm_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adres_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cell_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ln_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fn_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
    }
}