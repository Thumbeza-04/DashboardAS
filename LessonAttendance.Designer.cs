
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
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonAttendanceMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.AttendedBtn = new System.Windows.Forms.Button();
            this.Missed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.archBtn = new System.Windows.Forms.CheckBox();
            this.ArchiveBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lessonAttendanceMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.LessonAttendanceMJTableAdapter();
            this.outcomeMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.OutcomeMJTableAdapter();
            this.lessonBookingMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.LessonBookingMJTableAdapter();
            this.packageMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.PackageMJTableAdapter();
            this.studentMJTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.StudentMJTableAdapter();
            this.bookingTableAdapter = new DashboardAS.DSAttendance2TableAdapters.BookingTableAdapter();
            this.ReloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLbl1
            // 
            this.IDLbl1.AutoSize = true;
            this.IDLbl1.Location = new System.Drawing.Point(106, 42);
            this.IDLbl1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.IDLbl1.Name = "IDLbl1";
            this.IDLbl1.Size = new System.Drawing.Size(0, 17);
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
            this.packageIDDataGridViewTextBoxColumn,
            this.noOfLessonsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 150);
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
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfLessonsDataGridViewTextBoxColumn
            // 
            this.noOfLessonsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noOfLessonsDataGridViewTextBoxColumn.DataPropertyName = "NoOfLessons";
            this.noOfLessonsDataGridViewTextBoxColumn.HeaderText = "NoOfLessons";
            this.noOfLessonsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfLessonsDataGridViewTextBoxColumn.Name = "noOfLessonsDataGridViewTextBoxColumn";
            this.noOfLessonsDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.dsAttendance21;
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
            this.studentIDDataGridViewTextBoxColumn1,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn1,
            this.numberOfLessonsDataGridViewTextBoxColumn,
            this.attendedDataGridViewTextBoxColumn,
            this.missedDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lessonAttendanceMJBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 334);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(981, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // packageIDDataGridViewTextBoxColumn1
            // 
            this.packageIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packageIDDataGridViewTextBoxColumn1.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn1.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn1.Name = "packageIDDataGridViewTextBoxColumn1";
            this.packageIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numberOfLessonsDataGridViewTextBoxColumn
            // 
            this.numberOfLessonsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfLessonsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfLessons";
            this.numberOfLessonsDataGridViewTextBoxColumn.HeaderText = "NumberOfLessons";
            this.numberOfLessonsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfLessonsDataGridViewTextBoxColumn.Name = "numberOfLessonsDataGridViewTextBoxColumn";
            this.numberOfLessonsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendedDataGridViewTextBoxColumn
            // 
            this.attendedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendedDataGridViewTextBoxColumn.DataPropertyName = "Attended";
            this.attendedDataGridViewTextBoxColumn.HeaderText = "Attended";
            this.attendedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendedDataGridViewTextBoxColumn.Name = "attendedDataGridViewTextBoxColumn";
            this.attendedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // missedDataGridViewTextBoxColumn
            // 
            this.missedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.missedDataGridViewTextBoxColumn.DataPropertyName = "Missed";
            this.missedDataGridViewTextBoxColumn.HeaderText = "Missed";
            this.missedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.missedDataGridViewTextBoxColumn.Name = "missedDataGridViewTextBoxColumn";
            this.missedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainingDataGridViewTextBoxColumn
            // 
            this.remainingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining";
            this.remainingDataGridViewTextBoxColumn.HeaderText = "Remaining";
            this.remainingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remainingDataGridViewTextBoxColumn.Name = "remainingDataGridViewTextBoxColumn";
            this.remainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonAttendanceMJBindingSource
            // 
            this.lessonAttendanceMJBindingSource.DataMember = "LessonAttendanceMJ";
            this.lessonAttendanceMJBindingSource.DataSource = this.dsAttendance21;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.RegisterBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(746, 278);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(246, 34);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Add to Attendance Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // AttendedBtn
            // 
            this.AttendedBtn.BackColor = System.Drawing.Color.Gold;
            this.AttendedBtn.Location = new System.Drawing.Point(581, 441);
            this.AttendedBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AttendedBtn.Name = "AttendedBtn";
            this.AttendedBtn.Size = new System.Drawing.Size(132, 43);
            this.AttendedBtn.TabIndex = 4;
            this.AttendedBtn.Text = "Attended";
            this.AttendedBtn.UseVisualStyleBackColor = false;
            this.AttendedBtn.Click += new System.EventHandler(this.AttendedBtn_Click);
            // 
            // Missed
            // 
            this.Missed.BackColor = System.Drawing.Color.Red;
            this.Missed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missed.Location = new System.Drawing.Point(717, 441);
            this.Missed.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Missed.Name = "Missed";
            this.Missed.Size = new System.Drawing.Size(128, 43);
            this.Missed.TabIndex = 5;
            this.Missed.Text = "Missed";
            this.Missed.UseVisualStyleBackColor = false;
            this.Missed.Click += new System.EventHandler(this.Missed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReloadBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.archBtn);
            this.groupBox1.Controls.Add(this.ArchiveBtn);
            this.groupBox1.Controls.Add(this.Missed);
            this.groupBox1.Controls.Add(this.AttendedBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1071, 567);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Register";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(717, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reactivate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // archBtn
            // 
            this.archBtn.AutoSize = true;
            this.archBtn.Location = new System.Drawing.Point(4, 461);
            this.archBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.archBtn.Name = "archBtn";
            this.archBtn.Size = new System.Drawing.Size(155, 23);
            this.archBtn.TabIndex = 8;
            this.archBtn.Text = "Show Archived";
            this.archBtn.UseVisualStyleBackColor = true;
            this.archBtn.CheckedChanged += new System.EventHandler(this.archBtn_CheckedChanged);
            // 
            // ArchiveBtn
            // 
            this.ArchiveBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.ArchiveBtn.Location = new System.Drawing.Point(849, 441);
            this.ArchiveBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ArchiveBtn.Name = "ArchiveBtn";
            this.ArchiveBtn.Size = new System.Drawing.Size(132, 43);
            this.ArchiveBtn.TabIndex = 5;
            this.ArchiveBtn.Text = "Archive";
            this.ArchiveBtn.UseVisualStyleBackColor = false;
            this.ArchiveBtn.Click += new System.EventHandler(this.ArchiveBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(784, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lessonAttendanceMJTableAdapter1
            // 
            this.lessonAttendanceMJTableAdapter1.ClearBeforeFill = true;
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
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.BackColor = System.Drawing.Color.Indigo;
            this.ReloadBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadBtn.Location = new System.Drawing.Point(581, 488);
            this.ReloadBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(128, 43);
            this.ReloadBtn.TabIndex = 10;
            this.ReloadBtn.Text = "Reload";
            this.ReloadBtn.UseVisualStyleBackColor = false;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // LessonAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 688);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RegisterBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLbl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button AttendedBtn;
        private System.Windows.Forms.Button Missed;
        private System.Windows.Forms.GroupBox groupBox1;
        private DSAttendance2 dsAttendance21;
        private DSAttendance2TableAdapters.LessonAttendanceMJTableAdapter lessonAttendanceMJTableAdapter1;
        private DSAttendance2TableAdapters.LessonBookingMJTableAdapter lessonBookingMJTableAdapter1;
        private DSAttendance2TableAdapters.OutcomeMJTableAdapter outcomeMJTableAdapter1;
        private DSAttendance2TableAdapters.PackageMJTableAdapter packageMJTableAdapter1;
        private DSAttendance2TableAdapters.StudentMJTableAdapter studentMJTableAdapter1;
        private System.Windows.Forms.BindingSource lessonAttendanceMJBindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private DSAttendance2TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ArchiveBtn;
        private System.Windows.Forms.CheckBox archBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReloadBtn;
    }
}