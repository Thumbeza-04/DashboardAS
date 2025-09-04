
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
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.dSManager = new DashboardAS.DSManager();
            this.studentProgressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentProgressTableAdapter = new DashboardAS.DSAttendance2TableAdapters.StudentProgressTableAdapter();
            this.dsManager1 = new DashboardAS.DSManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporaryStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAttendance22 = new DashboardAS.DSAttendance2();
            this.dSAttendance2 = new DashboardAS.DSAttendance2();
            this.tempStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempStudentTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.TempStudentTableAdapter1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MissedBtn = new System.Windows.Forms.Button();
            this.attBtn = new System.Windows.Forms.Button();
            this.temporaryStudentsTableAdapter = new DashboardAS.DSAttendance2TableAdapters.TemporaryStudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempStudentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsAttendance21
            // 
            this.dsAttendance21.DataSetName = "DSAttendance2";
            this.dsAttendance21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSManager
            // 
            this.dSManager.DataSetName = "DSManager";
            this.dSManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.BookingID,
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.Attendance});
            this.dataGridView1.DataSource = this.temporaryStudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "BookingID";
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.MinimumWidth = 6;
            this.BookingID.Name = "BookingID";
            this.BookingID.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
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
            // Attendance
            // 
            this.Attendance.DataPropertyName = "Attendance";
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.MinimumWidth = 6;
            this.Attendance.Name = "Attendance";
            this.Attendance.Width = 125;
            // 
            // temporaryStudentsBindingSource
            // 
            this.temporaryStudentsBindingSource.DataMember = "TemporaryStudents";
            this.temporaryStudentsBindingSource.DataSource = this.dSAttendance22;
            // 
            // dSAttendance22
            // 
            this.dSAttendance22.DataSetName = "DSAttendance2";
            this.dSAttendance22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSAttendance2
            // 
            this.dSAttendance2.DataSetName = "DSAttendance2";
            this.dSAttendance2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tempStudentBindingSource
            // 
            this.tempStudentBindingSource.DataMember = "TempStudent";
            this.tempStudentBindingSource.DataSource = this.dSAttendance2;
            // 
            // tempStudentTableAdapter1
            // 
            this.tempStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MissedBtn);
            this.groupBox1.Controls.Add(this.attBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temporary Attendance Register";
            // 
            // MissedBtn
            // 
            this.MissedBtn.Location = new System.Drawing.Point(887, 215);
            this.MissedBtn.Name = "MissedBtn";
            this.MissedBtn.Size = new System.Drawing.Size(102, 32);
            this.MissedBtn.TabIndex = 1;
            this.MissedBtn.Text = "Missed";
            this.MissedBtn.UseVisualStyleBackColor = true;
            this.MissedBtn.Click += new System.EventHandler(this.MissedBtn_Click);
            // 
            // attBtn
            // 
            this.attBtn.Location = new System.Drawing.Point(780, 215);
            this.attBtn.Name = "attBtn";
            this.attBtn.Size = new System.Drawing.Size(88, 32);
            this.attBtn.TabIndex = 0;
            this.attBtn.Text = "Attended";
            this.attBtn.UseVisualStyleBackColor = true;
            this.attBtn.Click += new System.EventHandler(this.attBtn_Click);
            // 
            // temporaryStudentsTableAdapter
            // 
            this.temporaryStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewStudentProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudentProgress";
            this.Text = "ViewStudentProgress";
            this.Load += new System.EventHandler(this.ViewStudentProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempStudentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DSAttendance2 dsAttendance21;
        private System.Windows.Forms.BindingSource studentProgressBindingSource;
        private DSAttendance2TableAdapters.StudentProgressTableAdapter studentProgressTableAdapter;
        private DSManager dSManager;
        private DSManager dsManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DSAttendance2 dSAttendance2;
        private System.Windows.Forms.BindingSource tempStudentBindingSource;
        private DSAttendance2TableAdapters.TempStudentTableAdapter1 tempStudentTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MissedBtn;
        private System.Windows.Forms.Button attBtn;
        private DSAttendance2 dSAttendance22;
        private System.Windows.Forms.BindingSource temporaryStudentsBindingSource;
        private DSAttendance2TableAdapters.TemporaryStudentsTableAdapter temporaryStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
    }
}