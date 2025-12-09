namespace HotelManagementSystem.Forms
{
    partial class frmDashboard
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnQuickCheckIn = new System.Windows.Forms.Button();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblnavigation = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnCheckInOut = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblOccupancyRate = new System.Windows.Forms.Label();
            this.lblTodayRevenue = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvTodaySummary = new System.Windows.Forms.DataGridView();
            this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaySummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnNewReservation);
            this.panelHeader.Controls.Add(this.btnQuickCheckIn);
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Controls.Add(this.lblHotelName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 66);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.Location = new System.Drawing.Point(12, 19);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(261, 32);
            this.lblHotelName.TabIndex = 2;
            this.lblHotelName.Text = "JMS Hotel Dashboard";
            this.lblHotelName.Click += new System.EventHandler(this.lblHotelName_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(279, 32);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(135, 15);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Dec 10, 2025 10:00 AM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnQuickCheckIn
            // 
            this.btnQuickCheckIn.Location = new System.Drawing.Point(485, 18);
            this.btnQuickCheckIn.Name = "btnQuickCheckIn";
            this.btnQuickCheckIn.Size = new System.Drawing.Size(130, 33);
            this.btnQuickCheckIn.TabIndex = 4;
            this.btnQuickCheckIn.Text = "Quick Check-in";
            this.btnQuickCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.Location = new System.Drawing.Point(630, 18);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(138, 33);
            this.btnNewReservation.TabIndex = 5;
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = true;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.statusStrip1);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnBilling);
            this.panelSidebar.Controls.Add(this.btnRooms);
            this.panelSidebar.Controls.Add(this.btnCheckInOut);
            this.panelSidebar.Controls.Add(this.btnReservations);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblnavigation);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 66);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(211, 384);
            this.panelSidebar.TabIndex = 2;
            // 
            // lblnavigation
            // 
            this.lblnavigation.AutoSize = true;
            this.lblnavigation.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnavigation.Location = new System.Drawing.Point(13, 12);
            this.lblnavigation.Name = "lblnavigation";
            this.lblnavigation.Size = new System.Drawing.Size(103, 28);
            this.lblnavigation.TabIndex = 3;
            this.lblnavigation.Text = "Navigation";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(0, 53);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(211, 41);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(0, 100);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(211, 41);
            this.btnReservations.TabIndex = 7;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.Location = new System.Drawing.Point(0, 147);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(211, 41);
            this.btnCheckInOut.TabIndex = 8;
            this.btnCheckInOut.Text = "Check-in/Out";
            this.btnCheckInOut.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(0, 194);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(211, 41);
            this.btnRooms.TabIndex = 9;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(0, 241);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(211, 41);
            this.btnBilling.TabIndex = 10;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(0, 288);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(211, 41);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Location = new System.Drawing.Point(69, 40);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(125, 20);
            this.lblTotalRooms.TabIndex = 3;
            this.lblTotalRooms.Text = "Total Rooms: 50";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Location = new System.Drawing.Point(284, 40);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(153, 20);
            this.lblAvailableRooms.TabIndex = 4;
            this.lblAvailableRooms.Text = "Available Rooms: 12";
            // 
            // lblOccupancyRate
            // 
            this.lblOccupancyRate.AutoSize = true;
            this.lblOccupancyRate.Location = new System.Drawing.Point(69, 100);
            this.lblOccupancyRate.Name = "lblOccupancyRate";
            this.lblOccupancyRate.Size = new System.Drawing.Size(128, 20);
            this.lblOccupancyRate.TabIndex = 5;
            this.lblOccupancyRate.Text = "Occupancy: 76%";
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.AutoSize = true;
            this.lblTodayRevenue.Location = new System.Drawing.Point(284, 100);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(188, 20);
            this.lblTodayRevenue.TabIndex = 6;
            this.lblTodayRevenue.Text = "Revenue Today: ₱50,000";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.dgvTodaySummary);
            this.panelContent.Controls.Add(this.lblAvailableRooms);
            this.panelContent.Controls.Add(this.lblTodayRevenue);
            this.panelContent.Controls.Add(this.lblTotalRooms);
            this.panelContent.Controls.Add(this.lblOccupancyRate);
            this.panelContent.Location = new System.Drawing.Point(209, 66);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(591, 307);
            this.panelContent.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(211, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "Logged in as Admin";
            // 
            // dgvTodaySummary
            // 
            this.dgvTodaySummary.AllowUserToAddRows = false;
            this.dgvTodaySummary.AllowUserToDeleteRows = false;
            this.dgvTodaySummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodaySummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodaySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodaySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNumber,
            this.colGuestName});
            this.dgvTodaySummary.Location = new System.Drawing.Point(21, 147);
            this.dgvTodaySummary.Name = "dgvTodaySummary";
            this.dgvTodaySummary.RowHeadersVisible = false;
            this.dgvTodaySummary.RowHeadersWidth = 62;
            this.dgvTodaySummary.RowTemplate.Height = 28;
            this.dgvTodaySummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodaySummary.Size = new System.Drawing.Size(240, 150);
            this.dgvTodaySummary.TabIndex = 7;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.HeaderText = "Room Number";
            this.colRoomNumber.MinimumWidth = 8;
            this.colRoomNumber.Name = "colRoomNumber";
            // 
            // colGuestName
            // 
            this.colGuestName.HeaderText = "Guest Name";
            this.colGuestName.MinimumWidth = 8;
            this.colGuestName.Name = "colGuestName";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaySummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnQuickCheckIn;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblnavigation;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnCheckInOut;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label lblOccupancyRate;
        private System.Windows.Forms.Label lblTodayRevenue;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvTodaySummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuestName;
    }
}