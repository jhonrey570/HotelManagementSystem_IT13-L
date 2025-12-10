namespace HotelManagementSystem.Forms
{
    partial class frmRoomManagement
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelRoomDetails = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblSatus = new System.Windows.Forms.Label();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.cmbRoomTypeFilter = new System.Windows.Forms.ComboBox();
            this.cmbBuildingFilter = new System.Windows.Forms.ComboBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.gbRoomDetails = new System.Windows.Forms.GroupBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudFloor = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblRoomInfo = new System.Windows.Forms.Label();
            this.lblRoomImage = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnBlockRoom = new System.Windows.Forms.Button();
            this.picRoomImage = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelFilter.SuspendLayout();
            this.panelRoomDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.gbRoomDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Controls.Add(this.chkShowAll);
            this.panelFilter.Controls.Add(this.cmbStatusFilter);
            this.panelFilter.Controls.Add(this.cmbBuildingFilter);
            this.panelFilter.Controls.Add(this.cmbRoomTypeFilter);
            this.panelFilter.Controls.Add(this.btnClearFilter);
            this.panelFilter.Controls.Add(this.txtSearchRoom);
            this.panelFilter.Controls.Add(this.lblSatus);
            this.panelFilter.Controls.Add(this.lblBuilding);
            this.panelFilter.Controls.Add(this.lblRoomType);
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(797, 152);
            this.panelFilter.TabIndex = 0;
            // 
            // panelRoomDetails
            // 
            this.panelRoomDetails.Controls.Add(this.gbRoomDetails);
            this.panelRoomDetails.Controls.Add(this.btnBlockRoom);
            this.panelRoomDetails.Controls.Add(this.picRoomImage);
            this.panelRoomDetails.Controls.Add(this.lblRoomImage);
            this.panelRoomDetails.Controls.Add(this.btnDeleteRoom);
            this.panelRoomDetails.Controls.Add(this.btnAddRoom);
            this.panelRoomDetails.Controls.Add(this.btnEditRoom);
            this.panelRoomDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRoomDetails.Location = new System.Drawing.Point(0, 425);
            this.panelRoomDetails.Name = "panelRoomDetails";
            this.panelRoomDetails.Size = new System.Drawing.Size(797, 255);
            this.panelRoomDetails.TabIndex = 1;
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.Location = new System.Drawing.Point(0, 152);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 62;
            this.dgvRooms.RowTemplate.Height = 28;
            this.dgvRooms.Size = new System.Drawing.Size(797, 273);
            this.dgvRooms.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(35, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 28);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(35, 68);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(114, 28);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.Location = new System.Drawing.Point(35, 105);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(88, 28);
            this.lblBuilding.TabIndex = 2;
            this.lblBuilding.Text = "Building:";
            // 
            // lblSatus
            // 
            this.lblSatus.AutoSize = true;
            this.lblSatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatus.Location = new System.Drawing.Point(383, 68);
            this.lblSatus.Name = "lblSatus";
            this.lblSatus.Size = new System.Drawing.Size(69, 28);
            this.lblSatus.TabIndex = 3;
            this.lblSatus.Text = "Status:";
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Location = new System.Drawing.Point(169, 23);
            this.txtSearchRoom.Multiline = true;
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(150, 32);
            this.txtSearchRoom.TabIndex = 4;
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(366, 23);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(87, 32);
            this.btnClearFilter.TabIndex = 6;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // cmbRoomTypeFilter
            // 
            this.cmbRoomTypeFilter.FormattingEnabled = true;
            this.cmbRoomTypeFilter.Location = new System.Drawing.Point(169, 68);
            this.cmbRoomTypeFilter.Name = "cmbRoomTypeFilter";
            this.cmbRoomTypeFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbRoomTypeFilter.TabIndex = 7;
            // 
            // cmbBuildingFilter
            // 
            this.cmbBuildingFilter.FormattingEnabled = true;
            this.cmbBuildingFilter.Location = new System.Drawing.Point(169, 109);
            this.cmbBuildingFilter.Name = "cmbBuildingFilter";
            this.cmbBuildingFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbBuildingFilter.TabIndex = 8;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(468, 72);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbStatusFilter.TabIndex = 9;
            // 
            // chkShowAll
            // 
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.Location = new System.Drawing.Point(388, 113);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(96, 24);
            this.chkShowAll.TabIndex = 10;
            this.chkShowAll.Text = "Show All";
            this.chkShowAll.UseVisualStyleBackColor = true;
            // 
            // gbRoomDetails
            // 
            this.gbRoomDetails.Controls.Add(this.cmbStatus);
            this.gbRoomDetails.Controls.Add(this.nudFloor);
            this.gbRoomDetails.Controls.Add(this.nudRate);
            this.gbRoomDetails.Controls.Add(this.txtRoomNumber);
            this.gbRoomDetails.Controls.Add(this.lblStatus);
            this.gbRoomDetails.Controls.Add(this.lblRoomInfo);
            this.gbRoomDetails.Controls.Add(this.lblFloor);
            this.gbRoomDetails.Controls.Add(this.lblRate);
            this.gbRoomDetails.Controls.Add(this.lblRoomNo);
            this.gbRoomDetails.Location = new System.Drawing.Point(3, 3);
            this.gbRoomDetails.Name = "gbRoomDetails";
            this.gbRoomDetails.Size = new System.Drawing.Size(392, 250);
            this.gbRoomDetails.TabIndex = 0;
            this.gbRoomDetails.TabStop = false;
            this.gbRoomDetails.Text = "Room Details";
            this.gbRoomDetails.Enter += new System.EventHandler(this.gbRoomDetails_Enter);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(35, 25);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(100, 28);
            this.lblRoomNo.TabIndex = 12;
            this.lblRoomNo.Text = "Room No:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(35, 67);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(55, 28);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate:";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.Location = new System.Drawing.Point(35, 108);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(62, 28);
            this.lblFloor.TabIndex = 14;
            this.lblFloor.Text = "Floor:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(35, 146);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 28);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(169, 25);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(150, 32);
            this.txtRoomNumber.TabIndex = 12;
            // 
            // nudRate
            // 
            this.nudRate.Location = new System.Drawing.Point(169, 72);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(150, 26);
            this.nudRate.TabIndex = 16;
            // 
            // nudFloor
            // 
            this.nudFloor.Location = new System.Drawing.Point(169, 113);
            this.nudFloor.Name = "nudFloor";
            this.nudFloor.Size = new System.Drawing.Size(150, 26);
            this.nudFloor.TabIndex = 17;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(169, 149);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 28);
            this.cmbStatus.TabIndex = 12;
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomInfo.Location = new System.Drawing.Point(35, 190);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(172, 28);
            this.lblRoomInfo.TabIndex = 18;
            this.lblRoomInfo.Text = "Room Information";
            // 
            // lblRoomImage
            // 
            this.lblRoomImage.AutoSize = true;
            this.lblRoomImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomImage.Location = new System.Drawing.Point(408, 3);
            this.lblRoomImage.Name = "lblRoomImage";
            this.lblRoomImage.Size = new System.Drawing.Size(127, 28);
            this.lblRoomImage.TabIndex = 19;
            this.lblRoomImage.Text = "Room Image:";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(692, 57);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(87, 32);
            this.btnAddRoom.TabIndex = 12;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.Location = new System.Drawing.Point(692, 95);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(87, 32);
            this.btnEditRoom.TabIndex = 21;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.Location = new System.Drawing.Point(692, 133);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(87, 32);
            this.btnDeleteRoom.TabIndex = 22;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // btnBlockRoom
            // 
            this.btnBlockRoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockRoom.Location = new System.Drawing.Point(692, 171);
            this.btnBlockRoom.Name = "btnBlockRoom";
            this.btnBlockRoom.Size = new System.Drawing.Size(87, 32);
            this.btnBlockRoom.TabIndex = 23;
            this.btnBlockRoom.Text = "Block";
            this.btnBlockRoom.UseVisualStyleBackColor = true;
            // 
            // picRoomImage
            // 
            this.picRoomImage.Location = new System.Drawing.Point(413, 47);
            this.picRoomImage.Name = "picRoomImage";
            this.picRoomImage.Size = new System.Drawing.Size(238, 171);
            this.picRoomImage.TabIndex = 20;
            this.picRoomImage.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::HotelManagementSystem.Properties.Resources.icons8_search_50;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(325, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmRoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 680);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.panelRoomDetails);
            this.Controls.Add(this.panelFilter);
            this.Name = "frmRoomManagement";
            this.Text = "frmRoomManagement";
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelRoomDetails.ResumeLayout(false);
            this.panelRoomDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.gbRoomDetails.ResumeLayout(false);
            this.gbRoomDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelRoomDetails;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Label lblSatus;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbBuildingFilter;
        private System.Windows.Forms.ComboBox cmbRoomTypeFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbRoomDetails;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.NumericUpDown nudFloor;
        private System.Windows.Forms.Label lblRoomInfo;
        private System.Windows.Forms.PictureBox picRoomImage;
        private System.Windows.Forms.Label lblRoomImage;
        private System.Windows.Forms.Button btnBlockRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnAddRoom;
    }
}