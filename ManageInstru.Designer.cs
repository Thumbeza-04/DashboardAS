
namespace DashboardAS
{
    partial class ManageInstru
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.archBtn = new System.Windows.Forms.CheckBox();
            this.AttendedBtn = new System.Windows.Forms.Button();
            this.ArchiveBtn = new System.Windows.Forms.Button();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Missed = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonAttendanceMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsManager1 = new DashboardAS.DSManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bookingTableAdapter = new DashboardAS.DSManagerTableAdapters.BookingTableAdapter();
            this.lessonAttendanceMJTableAdapter = new DashboardAS.DSManagerTableAdapters.LessonAttendanceMJTableAdapter();
            this.lessonBookingMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonBookingMJTableAdapter = new DashboardAS.DSManagerTableAdapters.LessonBookingMJTableAdapter();
            this.tempStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempStudentsTableAdapter = new DashboardAS.DSManagerTableAdapters.TempStudentsTableAdapter();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reassignBtn = new System.Windows.Forms.Button();
            this.instruTxt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBookingMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.instruTxt);
            this.tabPage1.Controls.Add(this.reassignBtn);
            this.tabPage1.Controls.Add(this.archBtn);
            this.tabPage1.Controls.Add(this.AttendedBtn);
            this.tabPage1.Controls.Add(this.ArchiveBtn);
            this.tabPage1.Controls.Add(this.ReloadBtn);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Missed);
            this.tabPage1.Controls.Add(this.RegisterBtn);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendance Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // archBtn
            // 
            this.archBtn.AutoSize = true;
            this.archBtn.Location = new System.Drawing.Point(57, 516);
            this.archBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.archBtn.Name = "archBtn";
            this.archBtn.Size = new System.Drawing.Size(140, 21);
            this.archBtn.TabIndex = 13;
            this.archBtn.Text = "Show all students";
            this.archBtn.UseVisualStyleBackColor = true;
            this.archBtn.CheckedChanged += new System.EventHandler(this.archBtn_CheckedChanged);
            // 
            // AttendedBtn
            // 
            this.AttendedBtn.BackColor = System.Drawing.Color.Gold;
            this.AttendedBtn.Location = new System.Drawing.Point(824, 452);
            this.AttendedBtn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.AttendedBtn.Name = "AttendedBtn";
            this.AttendedBtn.Size = new System.Drawing.Size(132, 43);
            this.AttendedBtn.TabIndex = 5;
            this.AttendedBtn.Text = "Attended";
            this.AttendedBtn.UseVisualStyleBackColor = false;
            this.AttendedBtn.Click += new System.EventHandler(this.AttendedBtn_Click);
            // 
            // ArchiveBtn
            // 
            this.ArchiveBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.ArchiveBtn.Location = new System.Drawing.Point(963, 452);
            this.ArchiveBtn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ArchiveBtn.Name = "ArchiveBtn";
            this.ArchiveBtn.Size = new System.Drawing.Size(132, 43);
            this.ArchiveBtn.TabIndex = 6;
            this.ArchiveBtn.Text = "Archive";
            this.ArchiveBtn.UseVisualStyleBackColor = false;
            this.ArchiveBtn.Click += new System.EventHandler(this.ArchiveBtn_Click);
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.BackColor = System.Drawing.Color.Indigo;
            this.ReloadBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadBtn.Location = new System.Drawing.Point(828, 499);
            this.ReloadBtn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(127, 43);
            this.ReloadBtn.TabIndex = 11;
            this.ReloadBtn.Text = "Reload";
            this.ReloadBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(963, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reactivate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Missed
            // 
            this.Missed.BackColor = System.Drawing.Color.Red;
            this.Missed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missed.Location = new System.Drawing.Point(684, 452);
            this.Missed.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Missed.Name = "Missed";
            this.Missed.Size = new System.Drawing.Size(127, 43);
            this.Missed.TabIndex = 6;
            this.Missed.Text = "Missed";
            this.Missed.UseVisualStyleBackColor = false;
            this.Missed.Click += new System.EventHandler(this.Missed_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.RegisterBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(828, 220);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(245, 34);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Add to Attendance Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn1,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn1,
            this.packageIDDataGridViewTextBoxColumn1,
            this.numberOfLessonsDataGridViewTextBoxColumn,
            this.attendedDataGridViewTextBoxColumn,
            this.missedDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lessonAttendanceMJBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(40, 297);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1055, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructorIDDataGridViewTextBoxColumn1
            // 
            this.instructorIDDataGridViewTextBoxColumn1.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn1.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn1.Name = "instructorIDDataGridViewTextBoxColumn1";
            this.instructorIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // packageIDDataGridViewTextBoxColumn1
            // 
            this.packageIDDataGridViewTextBoxColumn1.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn1.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn1.Name = "packageIDDataGridViewTextBoxColumn1";
            this.packageIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numberOfLessonsDataGridViewTextBoxColumn
            // 
            this.numberOfLessonsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfLessons";
            this.numberOfLessonsDataGridViewTextBoxColumn.HeaderText = "NumberOfLessons";
            this.numberOfLessonsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfLessonsDataGridViewTextBoxColumn.Name = "numberOfLessonsDataGridViewTextBoxColumn";
            this.numberOfLessonsDataGridViewTextBoxColumn.Width = 125;
            // 
            // attendedDataGridViewTextBoxColumn
            // 
            this.attendedDataGridViewTextBoxColumn.DataPropertyName = "Attended";
            this.attendedDataGridViewTextBoxColumn.HeaderText = "Attended";
            this.attendedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendedDataGridViewTextBoxColumn.Name = "attendedDataGridViewTextBoxColumn";
            this.attendedDataGridViewTextBoxColumn.Width = 125;
            // 
            // missedDataGridViewTextBoxColumn
            // 
            this.missedDataGridViewTextBoxColumn.DataPropertyName = "Missed";
            this.missedDataGridViewTextBoxColumn.HeaderText = "Missed";
            this.missedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.missedDataGridViewTextBoxColumn.Name = "missedDataGridViewTextBoxColumn";
            this.missedDataGridViewTextBoxColumn.Width = 125;
            // 
            // remainingDataGridViewTextBoxColumn
            // 
            this.remainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining";
            this.remainingDataGridViewTextBoxColumn.HeaderText = "Remaining";
            this.remainingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remainingDataGridViewTextBoxColumn.Name = "remainingDataGridViewTextBoxColumn";
            this.remainingDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonAttendanceMJBindingSource
            // 
            this.lessonAttendanceMJBindingSource.DataMember = "LessonAttendanceMJ";
            this.lessonAttendanceMJBindingSource.DataSource = this.dsManager1;
            // 
            // dsManager1
            // 
            this.dsManager1.DataSetName = "DSManager";
            this.dsManager1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn,
            this.noOfLessonsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 150);
            this.dataGridView1.TabIndex = 0;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            this.instructorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // noOfLessonsDataGridViewTextBoxColumn
            // 
            this.noOfLessonsDataGridViewTextBoxColumn.DataPropertyName = "NoOfLessons";
            this.noOfLessonsDataGridViewTextBoxColumn.HeaderText = "NoOfLessons";
            this.noOfLessonsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfLessonsDataGridViewTextBoxColumn.Name = "noOfLessonsDataGridViewTextBoxColumn";
            this.noOfLessonsDataGridViewTextBoxColumn.Width = 125;
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
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.dsManager1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student Progress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // lessonAttendanceMJTableAdapter
            // 
            this.lessonAttendanceMJTableAdapter.ClearBeforeFill = true;
            // 
            // lessonBookingMJBindingSource
            // 
            this.lessonBookingMJBindingSource.DataMember = "LessonBookingMJ";
            this.lessonBookingMJBindingSource.DataSource = this.dsManager1;
            // 
            // lessonBookingMJTableAdapter
            // 
            this.lessonBookingMJTableAdapter.ClearBeforeFill = true;
            // 
            // tempStudentsBindingSource
            // 
            this.tempStudentsBindingSource.DataMember = "TempStudents";
            this.tempStudentsBindingSource.DataSource = this.dsManager1;
            // 
            // tempStudentsTableAdapter
            // 
            this.tempStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.dsManager1;
            // 
            // bookingBindingSource2
            // 
            this.bookingBindingSource2.DataMember = "Booking";
            this.bookingBindingSource2.DataSource = this.dsManager1;
            // 
            // reassignBtn
            // 
            this.reassignBtn.Location = new System.Drawing.Point(963, 259);
            this.reassignBtn.Name = "reassignBtn";
            this.reassignBtn.Size = new System.Drawing.Size(110, 32);
            this.reassignBtn.TabIndex = 14;
            this.reassignBtn.Text = "Reassign";
            this.reassignBtn.UseVisualStyleBackColor = true;
            this.reassignBtn.Click += new System.EventHandler(this.reassignBtn_Click);
            // 
            // instruTxt
            // 
            this.instruTxt.Location = new System.Drawing.Point(805, 269);
            this.instruTxt.Name = "instruTxt";
            this.instruTxt.Size = new System.Drawing.Size(140, 22);
            this.instruTxt.TabIndex = 15;
            // 
            // ManageInstru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 599);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageInstru";
            this.Text = "ManageInstru";
            this.Load += new System.EventHandler(this.ManageInstru_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBookingMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DSManager dsManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private DSManagerTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lessonAttendanceMJBindingSource;
        private DSManagerTableAdapters.LessonAttendanceMJTableAdapter lessonAttendanceMJTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button AttendedBtn;
        private System.Windows.Forms.Button Missed;
        private System.Windows.Forms.Button ArchiveBtn;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox archBtn;
        private System.Windows.Forms.BindingSource lessonBookingMJBindingSource;
        private DSManagerTableAdapters.LessonBookingMJTableAdapter lessonBookingMJTableAdapter;
        private System.Windows.Forms.BindingSource tempStudentsBindingSource;
        private DSManagerTableAdapters.TempStudentsTableAdapter tempStudentsTableAdapter;
        private System.Windows.Forms.BindingSource bookingBindingSource2;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private System.Windows.Forms.TextBox instruTxt;
        private System.Windows.Forms.Button reassignBtn;
    }
}