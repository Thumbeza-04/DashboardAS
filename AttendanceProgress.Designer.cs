
namespace DashboardAS
{
    partial class AttendanceProgress
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
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendanceSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceSheetTableAdapter = new DashboardAS.DSAttendance2TableAdapters.AttendanceSheetTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentProgressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentProgressTableAdapter = new DashboardAS.DSAttendance2TableAdapters.StudentProgressTableAdapter();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preTripChecksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedNGearControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlledIntersectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hillStartsNGradientControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingNReversingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laneChangingNOvertakingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freewayDrivingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mockTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsAttendance21
            // 
            this.dsAttendance21.DataSetName = "DSAttendance2";
            this.dsAttendance21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceSheetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // attendanceSheetBindingSource
            // 
            this.attendanceSheetBindingSource.DataMember = "AttendanceSheet";
            this.attendanceSheetBindingSource.DataSource = this.dsAttendance21;
            // 
            // attendanceSheetTableAdapter
            // 
            this.attendanceSheetTableAdapter.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn1,
            this.studentNameDataGridViewTextBoxColumn1,
            this.studentSurnameDataGridViewTextBoxColumn1,
            this.instructorIDDataGridViewTextBoxColumn,
            this.preTripChecksDataGridViewTextBoxColumn,
            this.vehicleControlDataGridViewTextBoxColumn,
            this.speedNGearControlDataGridViewTextBoxColumn,
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn,
            this.controlledIntersectionsDataGridViewTextBoxColumn,
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn,
            this.hillStartsNGradientControlDataGridViewTextBoxColumn,
            this.parkingNReversingDataGridViewTextBoxColumn,
            this.laneChangingNOvertakingDataGridViewTextBoxColumn,
            this.freewayDrivingDataGridViewTextBoxColumn,
            this.mockTestDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentProgressBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(24, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1179, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // studentProgressBindingSource
            // 
            this.studentProgressBindingSource.DataMember = "StudentProgress";
            this.studentProgressBindingSource.DataSource = this.dsAttendance21;
            // 
            // studentProgressTableAdapter
            // 
            this.studentProgressTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.Width = 99;
            // 
            // studentNameDataGridViewTextBoxColumn1
            // 
            this.studentNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.studentNameDataGridViewTextBoxColumn1.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn1.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn1.Name = "studentNameDataGridViewTextBoxColumn1";
            this.studentNameDataGridViewTextBoxColumn1.Width = 123;
            // 
            // studentSurnameDataGridViewTextBoxColumn1
            // 
            this.studentSurnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentSurnameDataGridViewTextBoxColumn1.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn1.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn1.Name = "studentSurnameDataGridViewTextBoxColumn1";
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            this.instructorIDDataGridViewTextBoxColumn.Width = 109;
            // 
            // preTripChecksDataGridViewTextBoxColumn
            // 
            this.preTripChecksDataGridViewTextBoxColumn.DataPropertyName = "PreTripChecks";
            this.preTripChecksDataGridViewTextBoxColumn.HeaderText = "PreTripChecks";
            this.preTripChecksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preTripChecksDataGridViewTextBoxColumn.Name = "preTripChecksDataGridViewTextBoxColumn";
            this.preTripChecksDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleControlDataGridViewTextBoxColumn
            // 
            this.vehicleControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vehicleControlDataGridViewTextBoxColumn.DataPropertyName = "VehicleControl";
            this.vehicleControlDataGridViewTextBoxColumn.HeaderText = "VehicleControl";
            this.vehicleControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleControlDataGridViewTextBoxColumn.Name = "vehicleControlDataGridViewTextBoxColumn";
            this.vehicleControlDataGridViewTextBoxColumn.Width = 128;
            // 
            // speedNGearControlDataGridViewTextBoxColumn
            // 
            this.speedNGearControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.speedNGearControlDataGridViewTextBoxColumn.DataPropertyName = "SpeedNGearControl";
            this.speedNGearControlDataGridViewTextBoxColumn.HeaderText = "SpeedNGearControl";
            this.speedNGearControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speedNGearControlDataGridViewTextBoxColumn.Name = "speedNGearControlDataGridViewTextBoxColumn";
            this.speedNGearControlDataGridViewTextBoxColumn.Width = 165;
            // 
            // observationalNDefensiveDrivingDataGridViewTextBoxColumn
            // 
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.DataPropertyName = "ObservationalNDefensiveDriving";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.HeaderText = "ObservationalNDefensiveDriving";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.Name = "observationalNDefensiveDrivingDataGridViewTextBoxColumn";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.Width = 242;
            // 
            // controlledIntersectionsDataGridViewTextBoxColumn
            // 
            this.controlledIntersectionsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.controlledIntersectionsDataGridViewTextBoxColumn.DataPropertyName = "ControlledIntersections";
            this.controlledIntersectionsDataGridViewTextBoxColumn.HeaderText = "ControlledIntersections";
            this.controlledIntersectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlledIntersectionsDataGridViewTextBoxColumn.Name = "controlledIntersectionsDataGridViewTextBoxColumn";
            this.controlledIntersectionsDataGridViewTextBoxColumn.Width = 181;
            // 
            // uncontrolledIntersectionsDataGridViewTextBoxColumn
            // 
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.DataPropertyName = "UncontrolledIntersections";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.HeaderText = "UncontrolledIntersections";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.Name = "uncontrolledIntersectionsDataGridViewTextBoxColumn";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.Width = 197;
            // 
            // hillStartsNGradientControlDataGridViewTextBoxColumn
            // 
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.DataPropertyName = "HillStartsNGradientControl";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.HeaderText = "HillStartsNGradientControl";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.Name = "hillStartsNGradientControlDataGridViewTextBoxColumn";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.Width = 203;
            // 
            // parkingNReversingDataGridViewTextBoxColumn
            // 
            this.parkingNReversingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.parkingNReversingDataGridViewTextBoxColumn.DataPropertyName = "ParkingNReversing";
            this.parkingNReversingDataGridViewTextBoxColumn.HeaderText = "ParkingNReversing";
            this.parkingNReversingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingNReversingDataGridViewTextBoxColumn.Name = "parkingNReversingDataGridViewTextBoxColumn";
            this.parkingNReversingDataGridViewTextBoxColumn.Width = 159;
            // 
            // laneChangingNOvertakingDataGridViewTextBoxColumn
            // 
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.DataPropertyName = "LaneChangingNOvertaking";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.HeaderText = "LaneChangingNOvertaking";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.Name = "laneChangingNOvertakingDataGridViewTextBoxColumn";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.Width = 208;
            // 
            // freewayDrivingDataGridViewTextBoxColumn
            // 
            this.freewayDrivingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.freewayDrivingDataGridViewTextBoxColumn.DataPropertyName = "FreewayDriving";
            this.freewayDrivingDataGridViewTextBoxColumn.HeaderText = "FreewayDriving";
            this.freewayDrivingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freewayDrivingDataGridViewTextBoxColumn.Name = "freewayDrivingDataGridViewTextBoxColumn";
            this.freewayDrivingDataGridViewTextBoxColumn.Width = 134;
            // 
            // mockTestDataGridViewTextBoxColumn
            // 
            this.mockTestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mockTestDataGridViewTextBoxColumn.DataPropertyName = "MockTest";
            this.mockTestDataGridViewTextBoxColumn.HeaderText = "MockTest";
            this.mockTestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mockTestDataGridViewTextBoxColumn.Name = "mockTestDataGridViewTextBoxColumn";
            this.mockTestDataGridViewTextBoxColumn.Width = 98;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Register";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1288, 253);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Progress";
            // 
            // AttendanceProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AttendanceProgress";
            this.Text = "AttendanceProgress";
            this.Load += new System.EventHandler(this.AttendanceProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSAttendance2 dsAttendance21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource attendanceSheetBindingSource;
        private DSAttendance2TableAdapters.AttendanceSheetTableAdapter attendanceSheetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource studentProgressBindingSource;
        private DSAttendance2TableAdapters.StudentProgressTableAdapter studentProgressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preTripChecksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedNGearControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationalNDefensiveDrivingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlledIntersectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uncontrolledIntersectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hillStartsNGradientControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingNReversingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laneChangingNOvertakingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freewayDrivingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mockTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}