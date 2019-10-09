namespace Amanye
{
    partial class Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSchools = new System.Windows.Forms.DataGridView();
            this.pnlManagerDropdown = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProperietor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSearchDirectory = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.txtHiddenForSchoolUpdate = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.School = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiddenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).BeginInit();
            this.pnlManagerDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Amanye.Properties.Resources.asset8;
            this.pictureBox3.Image = global::Amanye.Properties.Resources._3Lines;
            this.pictureBox3.Location = new System.Drawing.Point(996, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 41);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Amanye.Properties.Resources.asset8;
            this.pictureBox2.Image = global::Amanye.Properties.Resources.asset2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 62);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Amanye.Properties.Resources.asset8;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSchools
            // 
            this.dgvSchools.AllowUserToAddRows = false;
            this.dgvSchools.AllowUserToDeleteRows = false;
            this.dgvSchools.AllowUserToResizeColumns = false;
            this.dgvSchools.AllowUserToResizeRows = false;
            this.dgvSchools.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchools.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.School,
            this.Phone,
            this.Address,
            this.HiddenId});
            this.dgvSchools.Location = new System.Drawing.Point(24, 119);
            this.dgvSchools.Name = "dgvSchools";
            this.dgvSchools.ReadOnly = true;
            this.dgvSchools.RowHeadersVisible = false;
            this.dgvSchools.Size = new System.Drawing.Size(600, 399);
            this.dgvSchools.TabIndex = 7;
            this.dgvSchools.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchools_CellContentClick);
            this.dgvSchools.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchools_CellContentClick);
            this.dgvSchools.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchools_CellContentClick);
            this.dgvSchools.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchools_CellContentClick);
            // 
            // pnlManagerDropdown
            // 
            this.pnlManagerDropdown.Controls.Add(this.button1);
            this.pnlManagerDropdown.Controls.Add(this.BtnLogout);
            this.pnlManagerDropdown.Controls.Add(this.BtnEditUser);
            this.pnlManagerDropdown.Controls.Add(this.BtnAddUser);
            this.pnlManagerDropdown.Location = new System.Drawing.Point(878, 76);
            this.pnlManagerDropdown.Name = "pnlManagerDropdown";
            this.pnlManagerDropdown.Size = new System.Drawing.Size(181, 188);
            this.pnlManagerDropdown.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.BtnLogout.Location = new System.Drawing.Point(0, 132);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(180, 43);
            this.BtnLogout.TabIndex = 2;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditUser.Location = new System.Drawing.Point(0, 90);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(180, 43);
            this.BtnEditUser.TabIndex = 1;
            this.BtnEditUser.Text = "Edit User";
            this.BtnEditUser.UseVisualStyleBackColor = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.BtnAddUser.Location = new System.Drawing.Point(0, 48);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(180, 43);
            this.BtnAddUser.TabIndex = 0;
            this.BtnAddUser.Text = "Add User";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label4.Location = new System.Drawing.Point(662, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Properietor\'s Name";
            // 
            // TxtProperietor
            // 
            this.TxtProperietor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtProperietor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProperietor.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.TxtProperietor.ForeColor = System.Drawing.Color.Black;
            this.TxtProperietor.Location = new System.Drawing.Point(666, 136);
            this.TxtProperietor.Multiline = true;
            this.TxtProperietor.Name = "TxtProperietor";
            this.TxtProperietor.Size = new System.Drawing.Size(343, 47);
            this.TxtProperietor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label1.Location = new System.Drawing.Point(662, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "School Name";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSchoolName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchoolName.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtSchoolName.ForeColor = System.Drawing.Color.Black;
            this.txtSchoolName.Location = new System.Drawing.Point(666, 217);
            this.txtSchoolName.Multiline = true;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(343, 47);
            this.txtSchoolName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label2.Location = new System.Drawing.Point(662, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddress.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.TxtAddress.ForeColor = System.Drawing.Color.Black;
            this.TxtAddress.Location = new System.Drawing.Point(666, 381);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(343, 47);
            this.TxtAddress.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label3.Location = new System.Drawing.Point(662, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(666, 300);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(343, 47);
            this.txtPhone.TabIndex = 15;
            // 
            // txtSearchDirectory
            // 
            this.txtSearchDirectory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearchDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchDirectory.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtSearchDirectory.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchDirectory.Location = new System.Drawing.Point(24, 544);
            this.txtSearchDirectory.Multiline = true;
            this.txtSearchDirectory.Name = "txtSearchDirectory";
            this.txtSearchDirectory.Size = new System.Drawing.Size(343, 43);
            this.txtSearchDirectory.TabIndex = 17;
            this.txtSearchDirectory.Text = "Search Directory";
            this.txtSearchDirectory.TextChanged += new System.EventHandler(this.txtSearchDirectory_TextChanged);
            this.txtSearchDirectory.Enter += new System.EventHandler(this.txtSearchDirectory_Enter);
            this.txtSearchDirectory.Leave += new System.EventHandler(this.txtSearchDirectory_Leave);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(666, 453);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(133, 52);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportData.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.btnExportData.ForeColor = System.Drawing.Color.White;
            this.btnExportData.Location = new System.Drawing.Point(433, 534);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(191, 52);
            this.btnExportData.TabIndex = 19;
            this.btnExportData.Text = "Export Data";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // txtHiddenForSchoolUpdate
            // 
            this.txtHiddenForSchoolUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtHiddenForSchoolUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHiddenForSchoolUpdate.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.txtHiddenForSchoolUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtHiddenForSchoolUpdate.Location = new System.Drawing.Point(641, 76);
            this.txtHiddenForSchoolUpdate.Multiline = true;
            this.txtHiddenForSchoolUpdate.Name = "txtHiddenForSchoolUpdate";
            this.txtHiddenForSchoolUpdate.Size = new System.Drawing.Size(343, 47);
            this.txtHiddenForSchoolUpdate.TabIndex = 21;
            this.txtHiddenForSchoolUpdate.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name.Width = 150;
            // 
            // School
            // 
            this.School.HeaderText = "School";
            this.School.Name = "School";
            this.School.ReadOnly = true;
            this.School.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.School.Width = 150;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Phone.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.Width = 150;
            // 
            // HiddenId
            // 
            this.HiddenId.HeaderText = "Id";
            this.HiddenId.Name = "HiddenId";
            this.HiddenId.ReadOnly = true;
            this.HiddenId.Visible = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 653);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtSearchDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlManagerDropdown);
            this.Controls.Add(this.dgvSchools);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtProperietor);
            this.Controls.Add(this.txtHiddenForSchoolUpdate);
            this.Controls.Add(this.txtSchoolName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).EndInit();
            this.pnlManagerDropdown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvSchools;
        private System.Windows.Forms.Panel pnlManagerDropdown;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnEditUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProperietor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSearchDirectory;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.TextBox txtHiddenForSchoolUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn School;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenId;
    }
}

