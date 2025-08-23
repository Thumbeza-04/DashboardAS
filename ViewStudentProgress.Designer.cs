
namespace DashboardAS
{
    partial class ViewStudentProgress
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
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.studentProgressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentProgressTableAdapter = new DashboardAS.DSAttendance2TableAdapters.StudentProgressTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
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
            this.dataGridView1.DataSource = this.studentProgressBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsAttendance21
            // 
            this.dsAttendance21.DataSetName = "DSAttendance2";
            this.dsAttendance21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Student Evaluation\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1351, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Progress";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 99;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 123;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentSurnameDataGridViewTextBoxColumn.Width = 143;
            // 
            // preTripChecksDataGridViewTextBoxColumn
            // 
            this.preTripChecksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.preTripChecksDataGridViewTextBoxColumn.DataPropertyName = "PreTripChecks";
            this.preTripChecksDataGridViewTextBoxColumn.HeaderText = "PreTripChecks";
            this.preTripChecksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preTripChecksDataGridViewTextBoxColumn.Name = "preTripChecksDataGridViewTextBoxColumn";
            this.preTripChecksDataGridViewTextBoxColumn.ReadOnly = true;
            this.preTripChecksDataGridViewTextBoxColumn.Width = 130;
            // 
            // vehicleControlDataGridViewTextBoxColumn
            // 
            this.vehicleControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vehicleControlDataGridViewTextBoxColumn.DataPropertyName = "VehicleControl";
            this.vehicleControlDataGridViewTextBoxColumn.HeaderText = "VehicleControl";
            this.vehicleControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleControlDataGridViewTextBoxColumn.Name = "vehicleControlDataGridViewTextBoxColumn";
            this.vehicleControlDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleControlDataGridViewTextBoxColumn.Width = 128;
            // 
            // speedNGearControlDataGridViewTextBoxColumn
            // 
            this.speedNGearControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.speedNGearControlDataGridViewTextBoxColumn.DataPropertyName = "SpeedNGearControl";
            this.speedNGearControlDataGridViewTextBoxColumn.HeaderText = "SpeedNGearControl";
            this.speedNGearControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speedNGearControlDataGridViewTextBoxColumn.Name = "speedNGearControlDataGridViewTextBoxColumn";
            this.speedNGearControlDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedNGearControlDataGridViewTextBoxColumn.Width = 165;
            // 
            // observationalNDefensiveDrivingDataGridViewTextBoxColumn
            // 
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.DataPropertyName = "ObservationalNDefensiveDriving";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.HeaderText = "ObservationalNDefensiveDriving";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.Name = "observationalNDefensiveDrivingDataGridViewTextBoxColumn";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.ReadOnly = true;
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.Width = 242;
            // 
            // controlledIntersectionsDataGridViewTextBoxColumn
            // 
            this.controlledIntersectionsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.controlledIntersectionsDataGridViewTextBoxColumn.DataPropertyName = "ControlledIntersections";
            this.controlledIntersectionsDataGridViewTextBoxColumn.HeaderText = "ControlledIntersections";
            this.controlledIntersectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlledIntersectionsDataGridViewTextBoxColumn.Name = "controlledIntersectionsDataGridViewTextBoxColumn";
            this.controlledIntersectionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.controlledIntersectionsDataGridViewTextBoxColumn.Width = 181;
            // 
            // uncontrolledIntersectionsDataGridViewTextBoxColumn
            // 
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.DataPropertyName = "UncontrolledIntersections";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.HeaderText = "UncontrolledIntersections";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.Name = "uncontrolledIntersectionsDataGridViewTextBoxColumn";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.Width = 197;
            // 
            // hillStartsNGradientControlDataGridViewTextBoxColumn
            // 
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.DataPropertyName = "HillStartsNGradientControl";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.HeaderText = "HillStartsNGradientControl";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.Name = "hillStartsNGradientControlDataGridViewTextBoxColumn";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.ReadOnly = true;
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.Width = 203;
            // 
            // parkingNReversingDataGridViewTextBoxColumn
            // 
            this.parkingNReversingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.parkingNReversingDataGridViewTextBoxColumn.DataPropertyName = "ParkingNReversing";
            this.parkingNReversingDataGridViewTextBoxColumn.HeaderText = "ParkingNReversing";
            this.parkingNReversingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingNReversingDataGridViewTextBoxColumn.Name = "parkingNReversingDataGridViewTextBoxColumn";
            this.parkingNReversingDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingNReversingDataGridViewTextBoxColumn.Width = 159;
            // 
            // laneChangingNOvertakingDataGridViewTextBoxColumn
            // 
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.DataPropertyName = "LaneChangingNOvertaking";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.HeaderText = "LaneChangingNOvertaking";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.Name = "laneChangingNOvertakingDataGridViewTextBoxColumn";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.ReadOnly = true;
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.Width = 208;
            // 
            // freewayDrivingDataGridViewTextBoxColumn
            // 
            this.freewayDrivingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.freewayDrivingDataGridViewTextBoxColumn.DataPropertyName = "FreewayDriving";
            this.freewayDrivingDataGridViewTextBoxColumn.HeaderText = "FreewayDriving";
            this.freewayDrivingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freewayDrivingDataGridViewTextBoxColumn.Name = "freewayDrivingDataGridViewTextBoxColumn";
            this.freewayDrivingDataGridViewTextBoxColumn.ReadOnly = true;
            this.freewayDrivingDataGridViewTextBoxColumn.Width = 134;
            // 
            // mockTestDataGridViewTextBoxColumn
            // 
            this.mockTestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mockTestDataGridViewTextBoxColumn.DataPropertyName = "MockTest";
            this.mockTestDataGridViewTextBoxColumn.HeaderText = "MockTest";
            this.mockTestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mockTestDataGridViewTextBoxColumn.Name = "mockTestDataGridViewTextBoxColumn";
            this.mockTestDataGridViewTextBoxColumn.ReadOnly = true;
            this.mockTestDataGridViewTextBoxColumn.Width = 98;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Width = 103;
            // 
            // ViewStudentProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudentProgress";
            this.Text = "ViewStudentProgress";
            this.Load += new System.EventHandler(this.ViewStudentProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DSAttendance2 dsAttendance21;
        private System.Windows.Forms.BindingSource studentProgressBindingSource;
        private DSAttendance2TableAdapters.StudentProgressTableAdapter studentProgressTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
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
    }
}