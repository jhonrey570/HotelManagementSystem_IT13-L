namespace HotelManagementSystem.Forms
{
    partial class frmCheckInOut
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelReservationDetails = new System.Windows.Forms.Panel();
            this.lblBookingRef = new System.Windows.Forms.Label();
            this.txtBookingRef = new System.Windows.Forms.TextBox();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.dgvArrivals = new System.Windows.Forms.DataGridView();
            this.panelCheckIn = new System.Windows.Forms.Panel();
            this.gbGuestInfo = new System.Windows.Forms.GroupBox();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.chkEarlyCheckIn = new System.Windows.Forms.CheckBox();
            this.lblNotesCheckIn = new System.Windows.Forms.Label();
            this.rtbNotesCheckIn = new System.Windows.Forms.RichTextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalAm = new System.Windows.Forms.Label();
            this.chkLateCheckOut = new System.Windows.Forms.CheckBox();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAdditionalF = new System.Windows.Forms.Label();
            this.nudAdditionalFees = new System.Windows.Forms.NumericUpDown();
            this.lblPaymentM = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblBalanceD = new System.Windows.Forms.Label();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.lblNotesCheckOut = new System.Windows.Forms.Label();
            this.rtbCheckOut = new System.Windows.Forms.RichTextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelReservationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivals)).BeginInit();
            this.panelCheckIn.SuspendLayout();
            this.gbGuestInfo.SuspendLayout();
            this.gbPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalFees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1324, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelCheckIn);
            this.tabPage1.Controls.Add(this.dgvArrivals);
            this.tabPage1.Controls.Add(this.panelReservationDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1316, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arrival";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1316, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1316, 639);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Current Guests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelReservationDetails
            // 
            this.panelReservationDetails.Controls.Add(this.lblRoomNumber);
            this.panelReservationDetails.Controls.Add(this.lblRoomNum);
            this.panelReservationDetails.Controls.Add(this.txtGuestName);
            this.panelReservationDetails.Controls.Add(this.lblGuestName);
            this.panelReservationDetails.Controls.Add(this.btnSearchReservation);
            this.panelReservationDetails.Controls.Add(this.txtBookingRef);
            this.panelReservationDetails.Controls.Add(this.lblBookingRef);
            this.panelReservationDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReservationDetails.Location = new System.Drawing.Point(3, 3);
            this.panelReservationDetails.Name = "panelReservationDetails";
            this.panelReservationDetails.Size = new System.Drawing.Size(1310, 124);
            this.panelReservationDetails.TabIndex = 0;
            // 
            // lblBookingRef
            // 
            this.lblBookingRef.AutoSize = true;
            this.lblBookingRef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingRef.Location = new System.Drawing.Point(37, 16);
            this.lblBookingRef.Name = "lblBookingRef";
            this.lblBookingRef.Size = new System.Drawing.Size(108, 25);
            this.lblBookingRef.TabIndex = 0;
            this.lblBookingRef.Text = "Booking Ref";
            // 
            // txtBookingRef
            // 
            this.txtBookingRef.Location = new System.Drawing.Point(160, 17);
            this.txtBookingRef.Name = "txtBookingRef";
            this.txtBookingRef.Size = new System.Drawing.Size(147, 26);
            this.txtBookingRef.TabIndex = 1;
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.Location = new System.Drawing.Point(338, 17);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(77, 26);
            this.btnSearchReservation.TabIndex = 3;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = true;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(159, 57);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(148, 26);
            this.txtGuestName.TabIndex = 5;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(37, 56);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(109, 25);
            this.lblGuestName.TabIndex = 4;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Location = new System.Drawing.Point(38, 98);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(116, 20);
            this.lblRoomNum.TabIndex = 6;
            this.lblRoomNum.Text = "Room Number:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(160, 98);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(80, 20);
            this.lblRoomNumber.TabIndex = 7;
            this.lblRoomNumber.Text = "Room No.";
            // 
            // dgvArrivals
            // 
            this.dgvArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArrivals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArrivals.Location = new System.Drawing.Point(3, 127);
            this.dgvArrivals.Name = "dgvArrivals";
            this.dgvArrivals.RowHeadersWidth = 62;
            this.dgvArrivals.RowTemplate.Height = 28;
            this.dgvArrivals.Size = new System.Drawing.Size(1310, 509);
            this.dgvArrivals.TabIndex = 1;
            // 
            // panelCheckIn
            // 
            this.panelCheckIn.Controls.Add(this.gbPaymentInfo);
            this.panelCheckIn.Controls.Add(this.gbGuestInfo);
            this.panelCheckIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCheckIn.Location = new System.Drawing.Point(3, 341);
            this.panelCheckIn.Name = "panelCheckIn";
            this.panelCheckIn.Size = new System.Drawing.Size(1310, 295);
            this.panelCheckIn.TabIndex = 2;
            // 
            // gbGuestInfo
            // 
            this.gbGuestInfo.Controls.Add(this.btnCheckIn);
            this.gbGuestInfo.Controls.Add(this.rtbNotesCheckIn);
            this.gbGuestInfo.Controls.Add(this.lblNotesCheckIn);
            this.gbGuestInfo.Controls.Add(this.chkEarlyCheckIn);
            this.gbGuestInfo.Controls.Add(this.dtpCheckInTime);
            this.gbGuestInfo.Controls.Add(this.lblCheckInTime);
            this.gbGuestInfo.Location = new System.Drawing.Point(-7, 14);
            this.gbGuestInfo.Name = "gbGuestInfo";
            this.gbGuestInfo.Size = new System.Drawing.Size(459, 288);
            this.gbGuestInfo.TabIndex = 0;
            this.gbGuestInfo.TabStop = false;
            this.gbGuestInfo.Text = "Guest Info";
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTime.Location = new System.Drawing.Point(30, 34);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(124, 25);
            this.lblCheckInTime.TabIndex = 5;
            this.lblCheckInTime.Text = "Check-In Time";
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Location = new System.Drawing.Point(160, 34);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(273, 26);
            this.dtpCheckInTime.TabIndex = 6;
            // 
            // chkEarlyCheckIn
            // 
            this.chkEarlyCheckIn.AutoSize = true;
            this.chkEarlyCheckIn.Location = new System.Drawing.Point(160, 66);
            this.chkEarlyCheckIn.Name = "chkEarlyCheckIn";
            this.chkEarlyCheckIn.Size = new System.Drawing.Size(138, 24);
            this.chkEarlyCheckIn.TabIndex = 7;
            this.chkEarlyCheckIn.Text = "Early Check-In";
            this.chkEarlyCheckIn.UseVisualStyleBackColor = true;
            // 
            // lblNotesCheckIn
            // 
            this.lblNotesCheckIn.AutoSize = true;
            this.lblNotesCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesCheckIn.Location = new System.Drawing.Point(30, 86);
            this.lblNotesCheckIn.Name = "lblNotesCheckIn";
            this.lblNotesCheckIn.Size = new System.Drawing.Size(59, 25);
            this.lblNotesCheckIn.TabIndex = 8;
            this.lblNotesCheckIn.Text = "Notes";
            // 
            // rtbNotesCheckIn
            // 
            this.rtbNotesCheckIn.Location = new System.Drawing.Point(33, 126);
            this.rtbNotesCheckIn.Name = "rtbNotesCheckIn";
            this.rtbNotesCheckIn.Size = new System.Drawing.Size(240, 139);
            this.rtbNotesCheckIn.TabIndex = 9;
            this.rtbNotesCheckIn.Text = "";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(303, 168);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(88, 37);
            this.btnCheckIn.TabIndex = 8;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Controls.Add(this.btnCancel);
            this.gbPaymentInfo.Controls.Add(this.btnPrintReceipt);
            this.gbPaymentInfo.Controls.Add(this.btnProcessPayment);
            this.gbPaymentInfo.Controls.Add(this.btnCheckOut);
            this.gbPaymentInfo.Controls.Add(this.rtbCheckOut);
            this.gbPaymentInfo.Controls.Add(this.lblNotesCheckOut);
            this.gbPaymentInfo.Controls.Add(this.lblBalanceDue);
            this.gbPaymentInfo.Controls.Add(this.chkLateCheckOut);
            this.gbPaymentInfo.Controls.Add(this.dtpCheckOutTime);
            this.gbPaymentInfo.Controls.Add(this.lblBalanceD);
            this.gbPaymentInfo.Controls.Add(this.lblCheckOutTime);
            this.gbPaymentInfo.Controls.Add(this.lblTotalAm);
            this.gbPaymentInfo.Controls.Add(this.cmbPaymentMethod);
            this.gbPaymentInfo.Controls.Add(this.lblAdditionalF);
            this.gbPaymentInfo.Controls.Add(this.lblTotalAmount);
            this.gbPaymentInfo.Controls.Add(this.nudAdditionalFees);
            this.gbPaymentInfo.Controls.Add(this.lblPaymentM);
            this.gbPaymentInfo.Location = new System.Drawing.Point(458, 14);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Size = new System.Drawing.Size(849, 288);
            this.gbPaymentInfo.TabIndex = 10;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "Payment Info";
            // 
            // lblTotalAm
            // 
            this.lblTotalAm.AutoSize = true;
            this.lblTotalAm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAm.Location = new System.Drawing.Point(385, 95);
            this.lblTotalAm.Name = "lblTotalAm";
            this.lblTotalAm.Size = new System.Drawing.Size(123, 25);
            this.lblTotalAm.TabIndex = 8;
            this.lblTotalAm.Text = "Total Amount:";
            // 
            // chkLateCheckOut
            // 
            this.chkLateCheckOut.AutoSize = true;
            this.chkLateCheckOut.Location = new System.Drawing.Point(175, 66);
            this.chkLateCheckOut.Name = "chkLateCheckOut";
            this.chkLateCheckOut.Size = new System.Drawing.Size(147, 24);
            this.chkLateCheckOut.TabIndex = 7;
            this.chkLateCheckOut.Text = "Late Check-Out";
            this.chkLateCheckOut.UseVisualStyleBackColor = true;
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.Location = new System.Drawing.Point(175, 34);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.Size = new System.Drawing.Size(270, 26);
            this.dtpCheckOutTime.TabIndex = 6;
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTime.Location = new System.Drawing.Point(30, 34);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(139, 25);
            this.lblCheckOutTime.TabIndex = 5;
            this.lblCheckOutTime.Text = "Check-Out Time";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(563, 95);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 25);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "TotalAmount";
            // 
            // lblAdditionalF
            // 
            this.lblAdditionalF.AutoSize = true;
            this.lblAdditionalF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalF.Location = new System.Drawing.Point(385, 135);
            this.lblAdditionalF.Name = "lblAdditionalF";
            this.lblAdditionalF.Size = new System.Drawing.Size(138, 25);
            this.lblAdditionalF.TabIndex = 10;
            this.lblAdditionalF.Text = "Additional Fees:";
            // 
            // nudAdditionalFees
            // 
            this.nudAdditionalFees.Location = new System.Drawing.Point(568, 137);
            this.nudAdditionalFees.Name = "nudAdditionalFees";
            this.nudAdditionalFees.Size = new System.Drawing.Size(120, 26);
            this.nudAdditionalFees.TabIndex = 11;
            // 
            // lblPaymentM
            // 
            this.lblPaymentM.AutoSize = true;
            this.lblPaymentM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentM.Location = new System.Drawing.Point(385, 181);
            this.lblPaymentM.Name = "lblPaymentM";
            this.lblPaymentM.Size = new System.Drawing.Size(152, 25);
            this.lblPaymentM.TabIndex = 12;
            this.lblPaymentM.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(568, 182);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 28);
            this.cmbPaymentMethod.TabIndex = 13;
            // 
            // lblBalanceD
            // 
            this.lblBalanceD.AutoSize = true;
            this.lblBalanceD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceD.Location = new System.Drawing.Point(385, 229);
            this.lblBalanceD.Name = "lblBalanceD";
            this.lblBalanceD.Size = new System.Drawing.Size(112, 25);
            this.lblBalanceD.TabIndex = 14;
            this.lblBalanceD.Text = "Balance Due:";
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDue.Location = new System.Drawing.Point(563, 229);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(103, 25);
            this.lblBalanceDue.TabIndex = 15;
            this.lblBalanceDue.Text = "BalanceDue";
            // 
            // lblNotesCheckOut
            // 
            this.lblNotesCheckOut.AutoSize = true;
            this.lblNotesCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesCheckOut.Location = new System.Drawing.Point(30, 86);
            this.lblNotesCheckOut.Name = "lblNotesCheckOut";
            this.lblNotesCheckOut.Size = new System.Drawing.Size(59, 25);
            this.lblNotesCheckOut.TabIndex = 16;
            this.lblNotesCheckOut.Text = "Notes";
            // 
            // rtbCheckOut
            // 
            this.rtbCheckOut.Location = new System.Drawing.Point(35, 129);
            this.rtbCheckOut.Name = "rtbCheckOut";
            this.rtbCheckOut.Size = new System.Drawing.Size(240, 139);
            this.rtbCheckOut.TabIndex = 10;
            this.rtbCheckOut.Text = "";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(737, 95);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(99, 37);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.Location = new System.Drawing.Point(737, 138);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(99, 37);
            this.btnProcessPayment.TabIndex = 17;
            this.btnProcessPayment.Text = "Process";
            this.btnProcessPayment.UseVisualStyleBackColor = true;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(737, 181);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(99, 35);
            this.btnPrintReceipt.TabIndex = 18;
            this.btnPrintReceipt.Text = "Print";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(737, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 672);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCheckInOut";
            this.Text = "frmCheckInOut";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelReservationDetails.ResumeLayout(false);
            this.panelReservationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivals)).EndInit();
            this.panelCheckIn.ResumeLayout(false);
            this.gbGuestInfo.ResumeLayout(false);
            this.gbGuestInfo.PerformLayout();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelReservationDetails;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.TextBox txtBookingRef;
        private System.Windows.Forms.Label lblBookingRef;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.DataGridView dgvArrivals;
        private System.Windows.Forms.Panel panelCheckIn;
        private System.Windows.Forms.GroupBox gbGuestInfo;
        private System.Windows.Forms.CheckBox chkEarlyCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.RichTextBox rtbNotesCheckIn;
        private System.Windows.Forms.Label lblNotesCheckIn;
        private System.Windows.Forms.GroupBox gbPaymentInfo;
        private System.Windows.Forms.Label lblTotalAm;
        private System.Windows.Forms.CheckBox chkLateCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAdditionalF;
        private System.Windows.Forms.NumericUpDown nudAdditionalFees;
        private System.Windows.Forms.Label lblPaymentM;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblBalanceD;
        private System.Windows.Forms.Label lblBalanceDue;
        private System.Windows.Forms.Label lblNotesCheckOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.RichTextBox rtbCheckOut;
    }
}