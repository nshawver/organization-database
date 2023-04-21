namespace OrganizationDatabase.Forms
{
    partial class FormVolunteers
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
            this.labelVolPhone = new System.Windows.Forms.Label();
            this.labelVolEmail = new System.Windows.Forms.Label();
            this.labelVolLastName = new System.Windows.Forms.Label();
            this.labelVolFirstName = new System.Windows.Forms.Label();
            this.labelVolID = new System.Windows.Forms.Label();
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
            this.dataGridView1.TabIndex = 16;
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
            this.panelBtnBottom.TabIndex = 15;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(527, 14);
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
            this.buttonUpdate.Location = new System.Drawing.Point(618, 14);
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
            this.buttonDelete.Location = new System.Drawing.Point(709, 14);
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
            this.buttonSearch.TabIndex = 13;
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
            this.panelTop.Controls.Add(this.labelVolPhone);
            this.panelTop.Controls.Add(this.labelVolEmail);
            this.panelTop.Controls.Add(this.labelVolLastName);
            this.panelTop.Controls.Add(this.labelVolFirstName);
            this.panelTop.Controls.Add(this.labelVolID);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 180);
            this.panelTop.TabIndex = 12;
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
            this.labelOrgID.Location = new System.Drawing.Point(118, 31);
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
            // labelVolPhone
            // 
            this.labelVolPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolPhone.AutoSize = true;
            this.labelVolPhone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolPhone.Location = new System.Drawing.Point(67, 121);
            this.labelVolPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolPhone.Name = "labelVolPhone";
            this.labelVolPhone.Size = new System.Drawing.Size(103, 20);
            this.labelVolPhone.TabIndex = 4;
            this.labelVolPhone.Text = "Phone Number:";
            // 
            // labelVolEmail
            // 
            this.labelVolEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolEmail.AutoSize = true;
            this.labelVolEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolEmail.Location = new System.Drawing.Point(124, 98);
            this.labelVolEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolEmail.Name = "labelVolEmail";
            this.labelVolEmail.Size = new System.Drawing.Size(47, 20);
            this.labelVolEmail.TabIndex = 3;
            this.labelVolEmail.Text = "Email:";
            // 
            // labelVolLastName
            // 
            this.labelVolLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolLastName.AutoSize = true;
            this.labelVolLastName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolLastName.Location = new System.Drawing.Point(95, 76);
            this.labelVolLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolLastName.Name = "labelVolLastName";
            this.labelVolLastName.Size = new System.Drawing.Size(76, 20);
            this.labelVolLastName.TabIndex = 2;
            this.labelVolLastName.Text = "Last Name:";
            // 
            // labelVolFirstName
            // 
            this.labelVolFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolFirstName.AutoSize = true;
            this.labelVolFirstName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolFirstName.Location = new System.Drawing.Point(93, 53);
            this.labelVolFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolFirstName.Name = "labelVolFirstName";
            this.labelVolFirstName.Size = new System.Drawing.Size(78, 20);
            this.labelVolFirstName.TabIndex = 1;
            this.labelVolFirstName.Text = "First Name:";
            // 
            // labelVolID
            // 
            this.labelVolID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolID.AutoSize = true;
            this.labelVolID.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolID.Location = new System.Drawing.Point(122, 8);
            this.labelVolID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolID.Name = "labelVolID";
            this.labelVolID.Size = new System.Drawing.Size(49, 20);
            this.labelVolID.TabIndex = 0;
            this.labelVolID.Text = "Vol-ID:";
            // 
            // FormVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBtnBottom);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelTop);
            this.Name = "FormVolunteers";
            this.Text = "FormVolunteers";
            this.Load += new System.EventHandler(this.FormVolunteers_Load);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVolPhone;
        private System.Windows.Forms.Label labelVolEmail;
        private System.Windows.Forms.Label labelVolLastName;
        private System.Windows.Forms.Label labelVolFirstName;
        private System.Windows.Forms.Label labelVolID;
        private System.Windows.Forms.Label labelOrgID;
        private System.Windows.Forms.TextBox textBox7;
    }
}