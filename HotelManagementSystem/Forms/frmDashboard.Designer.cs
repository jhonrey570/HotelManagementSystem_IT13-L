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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQuickCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.QuickAction = new System.Windows.Forms.Label();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTodayArrivals = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTodayDepartures = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvAvailableRooms = new System.Windows.Forms.DataGridView();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOccupancy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblTodayRevenue = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblOccupancyRate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayArrivals)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayDepartures)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).BeginInit();
            this.panelLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupancy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.menuStrip1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(178, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(622, 66);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "JMS HOTEL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.checkinOutToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(622, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // checkinOutToolStripMenuItem
            // 
            this.checkinOutToolStripMenuItem.Name = "checkinOutToolStripMenuItem";
            this.checkinOutToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.checkinOutToolStripMenuItem.Text = "Check-in/Out";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnQuickCheckIn);
            this.panelSidebar.Controls.Add(this.btnCheckOut);
            this.panelSidebar.Controls.Add(this.btnCheckIn);
            this.panelSidebar.Controls.Add(this.QuickAction);
            this.panelSidebar.Controls.Add(this.btnNewReservation);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(178, 450);
            this.panelSidebar.TabIndex = 2;
            // 
            // btnQuickCheckIn
            // 
            this.btnQuickCheckIn.Location = new System.Drawing.Point(0, 277);
            this.btnQuickCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuickCheckIn.Name = "btnQuickCheckIn";
            this.btnQuickCheckIn.Size = new System.Drawing.Size(178, 50);
            this.btnQuickCheckIn.TabIndex = 5;
            this.btnQuickCheckIn.Text = "Quick Check In";
            this.btnQuickCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(0, 222);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(178, 50);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(0, 168);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(178, 50);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // QuickAction
            // 
            this.QuickAction.AutoSize = true;
            this.QuickAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickAction.Location = new System.Drawing.Point(11, 65);
            this.QuickAction.Name = "QuickAction";
            this.QuickAction.Size = new System.Drawing.Size(107, 23);
            this.QuickAction.TabIndex = 2;
            this.QuickAction.Text = "Quick Action";
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.Location = new System.Drawing.Point(0, 114);
            this.btnNewReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(178, 50);
            this.btnNewReservation.TabIndex = 1;
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(178, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tabControl1);
            this.panelContent.Controls.Add(this.panelLabels);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(178, 66);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(622, 362);
            this.panelContent.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 202);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 160);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTodayArrivals);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(614, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Today Arrivals";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTodayArrivals
            // 
            this.dgvTodayArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayArrivals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayArrivals.Location = new System.Drawing.Point(3, 2);
            this.dgvTodayArrivals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayArrivals.Name = "dgvTodayArrivals";
            this.dgvTodayArrivals.RowHeadersWidth = 62;
            this.dgvTodayArrivals.RowTemplate.Height = 28;
            this.dgvTodayArrivals.Size = new System.Drawing.Size(608, 127);
            this.dgvTodayArrivals.TabIndex = 0;
            this.dgvTodayArrivals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodayArrivals_CellContentClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTodayDepartures);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(525, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Today Departures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTodayDepartures
            // 
            this.dgvTodayDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayDepartures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayDepartures.Location = new System.Drawing.Point(3, 2);
            this.dgvTodayDepartures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayDepartures.Name = "dgvTodayDepartures";
            this.dgvTodayDepartures.RowHeadersWidth = 62;
            this.dgvTodayDepartures.RowTemplate.Height = 28;
            this.dgvTodayDepartures.Size = new System.Drawing.Size(519, 140);
            this.dgvTodayDepartures.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvAvailableRooms);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(525, 144);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Available Rooms";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAvailableRooms
            // 
            this.dgvAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailableRooms.Location = new System.Drawing.Point(0, 0);
            this.dgvAvailableRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAvailableRooms.Name = "dgvAvailableRooms";
            this.dgvAvailableRooms.RowHeadersWidth = 62;
            this.dgvAvailableRooms.RowTemplate.Height = 28;
            this.dgvAvailableRooms.Size = new System.Drawing.Size(525, 144);
            this.dgvAvailableRooms.TabIndex = 2;
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.chartRevenue);
            this.panelLabels.Controls.Add(this.chartOccupancy);
            this.panelLabels.Controls.Add(this.lblTotalRooms);
            this.panelLabels.Controls.Add(this.lblTodayRevenue);
            this.panelLabels.Controls.Add(this.lblAvailableRooms);
            this.panelLabels.Controls.Add(this.lblOccupancyRate);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(622, 202);
            this.panelLabels.TabIndex = 7;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(300, 85);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(188, 104);
            this.chartRevenue.TabIndex = 11;
            this.chartRevenue.Text = "chart1";
            // 
            // chartOccupancy
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOccupancy.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOccupancy.Legends.Add(legend2);
            this.chartOccupancy.Location = new System.Drawing.Point(43, 85);
            this.chartOccupancy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartOccupancy.Name = "chartOccupancy";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartOccupancy.Series.Add(series2);
            this.chartOccupancy.Size = new System.Drawing.Size(188, 104);
            this.chartOccupancy.TabIndex = 10;
            this.chartOccupancy.Text = "chart2";
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.Location = new System.Drawing.Point(72, 18);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(92, 20);
            this.lblTotalRooms.TabIndex = 3;
            this.lblTotalRooms.Text = "Total Rooms";
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.AutoSize = true;
            this.lblTodayRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayRevenue.Location = new System.Drawing.Point(316, 49);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(109, 20);
            this.lblTodayRevenue.TabIndex = 6;
            this.lblTodayRevenue.Text = "Today Revenue";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.Location = new System.Drawing.Point(316, 18);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(121, 20);
            this.lblAvailableRooms.TabIndex = 4;
            this.lblAvailableRooms.Text = "Available Rooms";
            // 
            // lblOccupancyRate
            // 
            this.lblOccupancyRate.AutoSize = true;
            this.lblOccupancyRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupancyRate.Location = new System.Drawing.Point(68, 49);
            this.lblOccupancyRate.Name = "lblOccupancyRate";
            this.lblOccupancyRate.Size = new System.Drawing.Size(115, 20);
            this.lblOccupancyRate.TabIndex = 5;
            this.lblOccupancyRate.Text = "Occupancy Rate";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayArrivals)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayDepartures)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).EndInit();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnQuickCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label QuickAction;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblTodayRevenue;
        private System.Windows.Forms.Label lblOccupancyRate;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTodayArrivals;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTodayDepartures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOccupancy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvAvailableRooms;
    }
}