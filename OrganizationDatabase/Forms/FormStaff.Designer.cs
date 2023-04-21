namespace OrganizationDatabase.Forms
{
    partial class FormStaff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBtnBottom = new System.Windows.Forms.Panel();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labelOrgID = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStaffPhone = new System.Windows.Forms.Label();
            this.labelStaffEmail = new System.Windows.Forms.Label();
            this.labelStaffLastName = new System.Windows.Forms.Label();
            this.labelStaffFirstName = new System.Windows.Forms.Label();
            this.labelStaffID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBtnBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(748, 167);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelBtnBottom
            // 
            this.panelBtnBottom.Controls.Add(this.buttonInsert);
            this.panelBtnBottom.Controls.Add(this.buttonUpdate);
            this.panelBtnBottom.Controls.Add(this.buttonDelete);
            this.panelBtnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtnBottom.Location = new System.Drawing.Point(0, 397);
            this.panelBtnBottom.Margin = new System.Windows.Forms.Padding(1);
            this.panelBtnBottom.Name = "panelBtnBottom";
            this.panelBtnBottom.Size = new System.Drawing.Size(800, 53);
            this.panelBtnBottom.TabIndex = 20;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(528, 14);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(1);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(82, 32);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(619, 14);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 32);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(710, 14);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 32);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Location = new System.Drawing.Point(173, 187);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(493, 20);
            this.textBox6.TabIndex = 11;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(71, 182);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 32);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBox7);
            this.panelTop.Controls.Add(this.labelOrgID);
            this.panelTop.Controls.Add(this.textBox5);
            this.panelTop.Controls.Add(this.textBox4);
            this.panelTop.Controls.Add(this.textBox3);
            this.panelTop.Controls.Add(this.textBox2);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.labelStaffPhone);
            this.panelTop.Controls.Add(this.labelStaffEmail);
            this.panelTop.Controls.Add(this.labelStaffLastName);
            this.panelTop.Controls.Add(this.labelStaffFirstName);
            this.panelTop.Controls.Add(this.labelStaffID);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 180);
            this.panelTop.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(173, 31);
            this.textBox7.Margin = new System.Windows.Forms.Padding(1);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(493, 20);
            this.textBox7.TabIndex = 6;
            // 
            // labelOrgID
            // 
            this.labelOrgID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOrgID.AutoSize = true;
            this.labelOrgID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrgID.Location = new System.Drawing.Point(120, 31);
            this.labelOrgID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelOrgID.Name = "labelOrgID";
            this.labelOrgID.Size = new System.Drawing.Size(53, 20);
            this.labelOrgID.TabIndex = 10;
            this.labelOrgID.Text = "Org-ID:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(173, 121);
            this.textBox5.Margin = new System.Windows.Forms.Padding(1);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(493, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(173, 98);
            this.textBox4.Margin = new System.Windows.Forms.Padding(1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(493, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(173, 76);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(493, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(173, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(493, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(173, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelStaffPhone
            // 
            this.labelStaffPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStaffPhone.AutoSize = true;
            this.labelStaffPhone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffPhone.Location = new System.Drawing.Point(70, 119);
            this.labelStaffPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStaffPhone.Name = "labelStaffPhone";
            this.labelStaffPhone.Size = new System.Drawing.Size(103, 20);
            this.labelStaffPhone.TabIndex = 4;
            this.labelStaffPhone.Text = "Phone Number:";
            // 
            // labelStaffEmail
            // 
            this.labelStaffEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStaffEmail.AutoSize = true;
            this.labelStaffEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffEmail.Location = new System.Drawing.Point(126, 98);
            this.labelStaffEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStaffEmail.Name = "labelStaffEmail";
            this.labelStaffEmail.Size = new System.Drawing.Size(47, 20);
            this.labelStaffEmail.TabIndex = 3;
            this.labelStaffEmail.Text = "Email:";
            // 
            // labelStaffLastName
            // 
            this.labelStaffLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStaffLastName.AutoSize = true;
            this.labelStaffLastName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffLastName.Location = new System.Drawing.Point(97, 76);
            this.labelStaffLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStaffLastName.Name = "labelStaffLastName";
            this.labelStaffLastName.Size = new System.Drawing.Size(76, 20);
            this.labelStaffLastName.TabIndex = 2;
            this.labelStaffLastName.Text = "Last Name:";
            // 
            // labelStaffFirstName
            // 
            this.labelStaffFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStaffFirstName.AutoSize = true;
            this.labelStaffFirstName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffFirstName.Location = new System.Drawing.Point(95, 53);
            this.labelStaffFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStaffFirstName.Name = "labelStaffFirstName";
            this.labelStaffFirstName.Size = new System.Drawing.Size(78, 20);
            this.labelStaffFirstName.TabIndex = 1;
            this.labelStaffFirstName.Text = "First Name:";
            // 
            // labelStaffID
            // 
            this.labelStaffID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffID.Location = new System.Drawing.Point(116, 8);
            this.labelStaffID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(57, 20);
            this.labelStaffID.TabIndex = 0;
            this.labelStaffID.Text = "Staff-ID:";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBtnBottom);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelTop);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBtnBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelBtnBottom;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labelOrgID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStaffPhone;
        private System.Windows.Forms.Label labelStaffEmail;
        private System.Windows.Forms.Label labelStaffLastName;
        private System.Windows.Forms.Label labelStaffFirstName;
        private System.Windows.Forms.Label labelStaffID;
    }
}