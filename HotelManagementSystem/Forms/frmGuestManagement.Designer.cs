namespace HotelManagementSystem.Forms
{
    partial class frmGuestManagement
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelGuestDetails = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbGuestDetails = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblIdType = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblGuestType = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbIdType = new System.Windows.Forms.ComboBox();
            this.cmbGuestType = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelGuestDetails.SuspendLayout();
            this.gbGuestDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnClear);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(902, 79);
            this.panelSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(35, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 28);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(126, 28);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(305, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::HotelManagementSystem.Properties.Resources.icons8_search_50;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(269, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(902, 587);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelGuestDetails
            // 
            this.panelGuestDetails.Controls.Add(this.btnDelete);
            this.panelGuestDetails.Controls.Add(this.btnUpdate);
            this.panelGuestDetails.Controls.Add(this.btnAdd);
            this.panelGuestDetails.Controls.Add(this.gbGuestDetails);
            this.panelGuestDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGuestDetails.Location = new System.Drawing.Point(0, 344);
            this.panelGuestDetails.Name = "panelGuestDetails";
            this.panelGuestDetails.Size = new System.Drawing.Size(902, 322);
            this.panelGuestDetails.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(24, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 28);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(24, 272);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 28);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(24, 227);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 28);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(24, 180);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 28);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(24, 82);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 28);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name";
            // 
            // gbGuestDetails
            // 
            this.gbGuestDetails.Controls.Add(this.dtpDOB);
            this.gbGuestDetails.Controls.Add(this.cmbGuestType);
            this.gbGuestDetails.Controls.Add(this.cmbIdType);
            this.gbGuestDetails.Controls.Add(this.txtNationality);
            this.gbGuestDetails.Controls.Add(this.txtIdNumber);
            this.gbGuestDetails.Controls.Add(this.txtCountry);
            this.gbGuestDetails.Controls.Add(this.lblIdType);
            this.gbGuestDetails.Controls.Add(this.lblIdNumber);
            this.gbGuestDetails.Controls.Add(this.lblGuestType);
            this.gbGuestDetails.Controls.Add(this.lblNationality);
            this.gbGuestDetails.Controls.Add(this.lblDOB);
            this.gbGuestDetails.Controls.Add(this.lblCountry);
            this.gbGuestDetails.Controls.Add(this.txtCity);
            this.gbGuestDetails.Controls.Add(this.txtAddress);
            this.gbGuestDetails.Controls.Add(this.txtPhone);
            this.gbGuestDetails.Controls.Add(this.txtEmail);
            this.gbGuestDetails.Controls.Add(this.txtLastName);
            this.gbGuestDetails.Controls.Add(this.txtFirstName);
            this.gbGuestDetails.Controls.Add(this.lblLastName);
            this.gbGuestDetails.Controls.Add(this.lblEmail);
            this.gbGuestDetails.Controls.Add(this.lblPhone);
            this.gbGuestDetails.Controls.Add(this.lblAddress);
            this.gbGuestDetails.Controls.Add(this.lblCity);
            this.gbGuestDetails.Controls.Add(this.lblFirstName);
            this.gbGuestDetails.Location = new System.Drawing.Point(3, 12);
            this.gbGuestDetails.Name = "gbGuestDetails";
            this.gbGuestDetails.Size = new System.Drawing.Size(767, 319);
            this.gbGuestDetails.TabIndex = 0;
            this.gbGuestDetails.TabStop = false;
            this.gbGuestDetails.Text = "Guest Details";
            this.gbGuestDetails.Enter += new System.EventHandler(this.gbGuestDetails_Enter);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(146, 37);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 30);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 86);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 30);
            this.txtLastName.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 134);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 30);
            this.txtEmail.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(146, 180);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(133, 30);
            this.txtPhone.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 227);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(133, 30);
            this.txtAddress.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(146, 272);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(133, 30);
            this.txtCity.TabIndex = 20;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(483, 227);
            this.txtNationality.Multiline = true;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(133, 30);
            this.txtNationality.TabIndex = 31;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(483, 134);
            this.txtIdNumber.Multiline = true;
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(133, 30);
            this.txtIdNumber.TabIndex = 28;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(483, 37);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(133, 30);
            this.txtCountry.TabIndex = 27;
            // 
            // lblIdType
            // 
            this.lblIdType.AutoSize = true;
            this.lblIdType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdType.Location = new System.Drawing.Point(362, 82);
            this.lblIdType.Name = "lblIdType";
            this.lblIdType.Size = new System.Drawing.Size(75, 28);
            this.lblIdType.TabIndex = 26;
            this.lblIdType.Text = "Id Type";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNumber.Location = new System.Drawing.Point(362, 134);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(106, 28);
            this.lblIdNumber.TabIndex = 25;
            this.lblIdNumber.Text = "Id Number";
            // 
            // lblGuestType
            // 
            this.lblGuestType.AutoSize = true;
            this.lblGuestType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestType.Location = new System.Drawing.Point(362, 180);
            this.lblGuestType.Name = "lblGuestType";
            this.lblGuestType.Size = new System.Drawing.Size(108, 28);
            this.lblGuestType.TabIndex = 24;
            this.lblGuestType.Text = "Guest Type";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(362, 227);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(109, 28);
            this.lblNationality.TabIndex = 23;
            this.lblNationality.Text = "Nationality";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(362, 272);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(85, 28);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "Birthday";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(362, 39);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(82, 28);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country";
            // 
            // cmbIdType
            // 
            this.cmbIdType.FormattingEnabled = true;
            this.cmbIdType.Location = new System.Drawing.Point(483, 86);
            this.cmbIdType.Name = "cmbIdType";
            this.cmbIdType.Size = new System.Drawing.Size(133, 28);
            this.cmbIdType.TabIndex = 33;
            // 
            // cmbGuestType
            // 
            this.cmbGuestType.FormattingEnabled = true;
            this.cmbGuestType.Location = new System.Drawing.Point(483, 180);
            this.cmbGuestType.Name = "cmbGuestType";
            this.cmbGuestType.Size = new System.Drawing.Size(133, 28);
            this.cmbGuestType.TabIndex = 34;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(483, 274);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(270, 26);
            this.dtpDOB.TabIndex = 35;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(796, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(796, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(796, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmGuestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 666);
            this.Controls.Add(this.panelGuestDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSearch);
            this.Name = "frmGuestManagement";
            this.Text = "frmGuestManagement";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelGuestDetails.ResumeLayout(false);
            this.gbGuestDetails.ResumeLayout(false);
            this.gbGuestDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelGuestDetails;
        private System.Windows.Forms.GroupBox gbGuestDetails;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblIdType;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblGuestType;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbGuestType;
        private System.Windows.Forms.ComboBox cmbIdType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}