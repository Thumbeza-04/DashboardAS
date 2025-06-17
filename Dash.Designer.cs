
namespace DashboardAS
{
    partial class Dash
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TodayTxt = new System.Windows.Forms.TextBox();
            this.monthTxt = new System.Windows.Forms.TextBox();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSlotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonBookingMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAttendance = new DashboardAS.DSAttendance();
            this.lessonBookingMJTableAdapter1 = new DashboardAS.DSAttendanceTableAdapters.LessonBookingMJTableAdapter();
            this.Lbl = new System.Windows.Forms.Label();
            this.dtLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBookingMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn,
            this.timeSlotIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBookingMJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // TodayTxt
            // 
            this.TodayTxt.Location = new System.Drawing.Point(222, 74);
            this.TodayTxt.Multiline = true;
            this.TodayTxt.Name = "TodayTxt";
            this.TodayTxt.Size = new System.Drawing.Size(70, 56);
            this.TodayTxt.TabIndex = 3;
            // 
            // monthTxt
            // 
            this.monthTxt.Location = new System.Drawing.Point(357, 74);
            this.monthTxt.Multiline = true;
            this.monthTxt.Name = "monthTxt";
            this.monthTxt.Size = new System.Drawing.Size(68, 56);
            this.monthTxt.TabIndex = 4;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            this.instructorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeSlotIDDataGridViewTextBoxColumn
            // 
            this.timeSlotIDDataGridViewTextBoxColumn.DataPropertyName = "TimeSlotID";
            this.timeSlotIDDataGridViewTextBoxColumn.HeaderText = "TimeSlotID";
            this.timeSlotIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeSlotIDDataGridViewTextBoxColumn.Name = "timeSlotIDDataGridViewTextBoxColumn";
            this.timeSlotIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonBookingMJBindingSource
            // 
            this.lessonBookingMJBindingSource.DataMember = "LessonBookingMJ";
            this.lessonBookingMJBindingSource.DataSource = this.dSAttendance;
            // 
            // dSAttendance
            // 
            this.dSAttendance.DataSetName = "DSAttendance";
            this.dSAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonBookingMJTableAdapter1
            // 
            this.lessonBookingMJTableAdapter1.ClearBeforeFill = true;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(46, 34);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(0, 17);
            this.Lbl.TabIndex = 1;
            // 
            // dtLbl
            // 
            this.dtLbl.AutoSize = true;
            this.dtLbl.Location = new System.Drawing.Point(46, 70);
            this.dtLbl.Name = "dtLbl";
            this.dtLbl.Size = new System.Drawing.Size(0, 17);
            this.dtLbl.TabIndex = 2;
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthTxt);
            this.Controls.Add(this.TodayTxt);
            this.Controls.Add(this.dtLbl);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dash";
            this.Text = "Dash";
            this.Load += new System.EventHandler(this.Dash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBookingMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAttendanceTableAdapters.LessonBookingMJTableAdapter lessonBookingMJTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSlotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lessonBookingMJBindingSource;
        private DSAttendance dSAttendance;
        private System.Windows.Forms.TextBox TodayTxt;
        private System.Windows.Forms.TextBox monthTxt;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label dtLbl;
    }
}