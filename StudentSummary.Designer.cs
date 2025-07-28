
namespace DashboardAS
{
    partial class StudentSummary
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLessonAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAttendance = new DashboardAS.DSAttendance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f_LessonAttendanceTableAdapter = new DashboardAS.DSAttendanceTableAdapters.F_LessonAttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLessonAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn,
            this.numberofLessonsDataGridViewTextBoxColumn,
            this.attendedDataGridViewTextBoxColumn,
            this.missedDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fLessonAttendanceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 68);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(796, 120);
            this.dataGridView2.TabIndex = 1;
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
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            this.packageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            this.packageIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofLessonsDataGridViewTextBoxColumn
            // 
            this.numberofLessonsDataGridViewTextBoxColumn.DataPropertyName = "NumberofLessons";
            this.numberofLessonsDataGridViewTextBoxColumn.HeaderText = "NumberofLessons";
            this.numberofLessonsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofLessonsDataGridViewTextBoxColumn.Name = "numberofLessonsDataGridViewTextBoxColumn";
            this.numberofLessonsDataGridViewTextBoxColumn.Width = 125;
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
            // fLessonAttendanceBindingSource
            // 
            this.fLessonAttendanceBindingSource.DataMember = "F_LessonAttendance";
            this.fLessonAttendanceBindingSource.DataSource = this.dSAttendance;
            // 
            // dSAttendance
            // 
            this.dSAttendance.DataSetName = "DSAttendance";
            this.dSAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(823, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Student ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(702, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // f_LessonAttendanceTableAdapter
            // 
            this.f_LessonAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // StudentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentSummary";
            this.Text = "StudentSummary";
            this.Load += new System.EventHandler(this.StudentSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLessonAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DSAttendance dSAttendance;
        private System.Windows.Forms.BindingSource fLessonAttendanceBindingSource;
        private DSAttendanceTableAdapters.F_LessonAttendanceTableAdapter f_LessonAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
    }
}