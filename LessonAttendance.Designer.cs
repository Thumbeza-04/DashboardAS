
namespace DashboardAS
{
    partial class LessonAttendance
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
            this.IDLbl1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAttendance2 = new DashboardAS.DSAttendance2();
            this.AttendedBtn = new System.Windows.Forms.Button();
            this.Missed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.outcomeMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.OutcomeMJTableAdapter();
            this.lessonBookingMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.LessonBookingMJTableAdapter();
            this.packageMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.PackageMJTableAdapter();
            this.studentMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.StudentMJTableAdapter();
            this.bookingsTableAdapter = new DashboardAS.DSAttendance2TableAdapters.BookingsTableAdapter();
            this.lA_SheetTableAdapter = new DashboardAS.DSAttendance2TableAdapters.LA_SheetTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lASheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLbl1
            // 
            this.IDLbl1.AutoSize = true;
            this.IDLbl1.Location = new System.Drawing.Point(121, 42);
            this.IDLbl1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.IDLbl1.Name = "IDLbl1";
            this.IDLbl1.Size = new System.Drawing.Size(0, 16);
            this.IDLbl1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.packageNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            this.packageNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            this.packageNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.dsAttendance21;
            // 
            // dsAttendance21
            // 
            this.dsAttendance21.DataSetName = "DSAttendance2";
            this.dsAttendance21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn1,
            this.studentIDDataGridViewTextBoxColumn1,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.bookingTimeDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.packageIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lASheetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(10, 334);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1121, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // bookingIDDataGridViewTextBoxColumn1
            // 
            this.bookingIDDataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn1.Name = "bookingIDDataGridViewTextBoxColumn1";
            this.bookingIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingTimeDataGridViewTextBoxColumn
            // 
            this.bookingTimeDataGridViewTextBoxColumn.DataPropertyName = "BookingTime";
            this.bookingTimeDataGridViewTextBoxColumn.HeaderText = "BookingTime";
            this.bookingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingTimeDataGridViewTextBoxColumn.Name = "bookingTimeDataGridViewTextBoxColumn";
            this.bookingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lASheetBindingSource
            // 
            this.lASheetBindingSource.DataMember = "LA_Sheet";
            this.lASheetBindingSource.DataSource = this.dSAttendance2;
            // 
            // dSAttendance2
            // 
            this.dSAttendance2.DataSetName = "DSAttendance2";
            this.dSAttendance2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AttendedBtn
            // 
            this.AttendedBtn.BackColor = System.Drawing.Color.Gold;
            this.AttendedBtn.Location = new System.Drawing.Point(793, 216);
            this.AttendedBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AttendedBtn.Name = "AttendedBtn";
            this.AttendedBtn.Size = new System.Drawing.Size(151, 43);
            this.AttendedBtn.TabIndex = 4;
            this.AttendedBtn.Text = "Present";
            this.AttendedBtn.UseVisualStyleBackColor = false;
            this.AttendedBtn.Click += new System.EventHandler(this.AttendedBtn_Click);
            // 
            // Missed
            // 
            this.Missed.BackColor = System.Drawing.Color.Red;
            this.Missed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missed.Location = new System.Drawing.Point(975, 216);
            this.Missed.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Missed.Name = "Missed";
            this.Missed.Size = new System.Drawing.Size(146, 43);
            this.Missed.TabIndex = 5;
            this.Missed.Text = "Absent";
            this.Missed.UseVisualStyleBackColor = false;
            this.Missed.Click += new System.EventHandler(this.Missed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReloadBtn);
            this.groupBox1.Controls.Add(this.Missed);
            this.groupBox1.Controls.Add(this.AttendedBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1224, 567);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Register";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.BackColor = System.Drawing.Color.Indigo;
            this.ReloadBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadBtn.Location = new System.Drawing.Point(819, 441);
            this.ReloadBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(302, 43);
            this.ReloadBtn.TabIndex = 10;
            this.ReloadBtn.Text = "Reload";
            this.ReloadBtn.UseVisualStyleBackColor = false;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(896, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // outcomeMJTableAdapter1
            // 
            this.outcomeMJTableAdapter1.ClearBeforeFill = true;
            // 
            // lessonBookingMJTableAdapter1
            // 
            this.lessonBookingMJTableAdapter1.ClearBeforeFill = true;
            // 
            // packageMJTableAdapter1
            // 
            this.packageMJTableAdapter1.ClearBeforeFill = true;
            // 
            // studentMJTableAdapter1
            // 
            this.studentMJTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // lA_SheetTableAdapter
            // 
            this.lA_SheetTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "*Double click for student to appear in Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Attendance";
            // 
            // LessonAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 688);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDLbl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "LessonAttendance";
            this.Text = "LessonAttendance";
            this.Load += new System.EventHandler(this.LessonAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lASheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLbl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AttendedBtn;
        private System.Windows.Forms.Button Missed;
        private System.Windows.Forms.GroupBox groupBox1;
        private DSAttendance2 dsAttendance21;
        private DSAttendance2TableAdapters.LessonBookingMJTableAdapter lessonBookingMJTableAdapter1;
        private DSAttendance2TableAdapters.OutcomeMJTableAdapter outcomeMJTableAdapter1;
        private DSAttendance2TableAdapters.PackageMJTableAdapter packageMJTableAdapter1;
        private DSAttendance2TableAdapters.StudentMJTableAdapter studentMJTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DSAttendance2TableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private DSAttendance2 dSAttendance2;
        private System.Windows.Forms.BindingSource lASheetBindingSource;
        private DSAttendance2TableAdapters.LA_SheetTableAdapter lA_SheetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}