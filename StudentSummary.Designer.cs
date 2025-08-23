
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
            this.lessonAttendanceMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lessonAttendanceMJTableAdapter = new DashboardAS.DSAttendance2TableAdapters.LessonAttendanceMJTableAdapter();
            this.studentProgressTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.StudentProgressTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.StuIdLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CInterGB = new System.Windows.Forms.GroupBox();
            this.ConRB3 = new System.Windows.Forms.RadioButton();
            this.ConRB1 = new System.Windows.Forms.RadioButton();
            this.ConRB2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CommentsGB = new System.Windows.Forms.GroupBox();
            this.CommentTxt = new System.Windows.Forms.TextBox();
            this.TestGB = new System.Windows.Forms.GroupBox();
            this.TRB3 = new System.Windows.Forms.RadioButton();
            this.TRB2 = new System.Windows.Forms.RadioButton();
            this.TRB1 = new System.Windows.Forms.RadioButton();
            this.FreewayGB = new System.Windows.Forms.GroupBox();
            this.FWRB3 = new System.Windows.Forms.RadioButton();
            this.FWRB1 = new System.Windows.Forms.RadioButton();
            this.FWRB2 = new System.Windows.Forms.RadioButton();
            this.LaneGB = new System.Windows.Forms.GroupBox();
            this.LnRB3 = new System.Windows.Forms.RadioButton();
            this.LnRB1 = new System.Windows.Forms.RadioButton();
            this.LnRB2 = new System.Windows.Forms.RadioButton();
            this.ParkingGB = new System.Windows.Forms.GroupBox();
            this.ParkRB3 = new System.Windows.Forms.RadioButton();
            this.ParkRB1 = new System.Windows.Forms.RadioButton();
            this.ParkRB2 = new System.Windows.Forms.RadioButton();
            this.HillGB = new System.Windows.Forms.GroupBox();
            this.HillRB3 = new System.Windows.Forms.RadioButton();
            this.HillRB1 = new System.Windows.Forms.RadioButton();
            this.HillRB2 = new System.Windows.Forms.RadioButton();
            this.UnInterGB = new System.Windows.Forms.GroupBox();
            this.UnconRB3 = new System.Windows.Forms.RadioButton();
            this.UnconRB1 = new System.Windows.Forms.RadioButton();
            this.UnconRB2 = new System.Windows.Forms.RadioButton();
            this.DDrivingGB = new System.Windows.Forms.GroupBox();
            this.DefRB3 = new System.Windows.Forms.RadioButton();
            this.DefRB2 = new System.Windows.Forms.RadioButton();
            this.DefRB1 = new System.Windows.Forms.RadioButton();
            this.SpeedGB = new System.Windows.Forms.GroupBox();
            this.GearRB3 = new System.Windows.Forms.RadioButton();
            this.GearRB2 = new System.Windows.Forms.RadioButton();
            this.GearRB1 = new System.Windows.Forms.RadioButton();
            this.VehControlGB = new System.Windows.Forms.GroupBox();
            this.VRB3 = new System.Windows.Forms.RadioButton();
            this.VRB2 = new System.Windows.Forms.RadioButton();
            this.VRB1 = new System.Windows.Forms.RadioButton();
            this.PreGB = new System.Windows.Forms.GroupBox();
            this.PRB3 = new System.Windows.Forms.RadioButton();
            this.PRB2 = new System.Windows.Forms.RadioButton();
            this.PRB1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CInterGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CommentsGB.SuspendLayout();
            this.TestGB.SuspendLayout();
            this.FreewayGB.SuspendLayout();
            this.LaneGB.SuspendLayout();
            this.ParkingGB.SuspendLayout();
            this.HillGB.SuspendLayout();
            this.UnInterGB.SuspendLayout();
            this.DDrivingGB.SuspendLayout();
            this.SpeedGB.SuspendLayout();
            this.VehControlGB.SuspendLayout();
            this.PreGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonAttendanceMJBindingSource
            // 
            this.lessonAttendanceMJBindingSource.DataMember = "LessonAttendanceMJ";
            this.lessonAttendanceMJBindingSource.DataSource = this.dsAttendance21;
            // 
            // dsAttendance21
            // 
            this.dsAttendance21.DataSetName = "DSAttendance2";
            this.dsAttendance21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Student Name\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(936, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lessonAttendanceMJTableAdapter
            // 
            this.lessonAttendanceMJTableAdapter.ClearBeforeFill = true;
            // 
            // studentProgressTableAdapter1
            // 
            this.studentProgressTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn,
            this.numberOfLessonsDataGridViewTextBoxColumn,
            this.attendedDataGridViewTextBoxColumn,
            this.missedDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lessonAttendanceMJBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1165, 148);
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
            // SNameLbl
            // 
            this.SNameLbl.Location = new System.Drawing.Point(258, 23);
            this.SNameLbl.Name = "SNameLbl";
            this.SNameLbl.Size = new System.Drawing.Size(159, 19);
            this.SNameLbl.TabIndex = 3;
            this.SNameLbl.Text = "StudentSurnam";
            // 
            // NameLbl
            // 
            this.NameLbl.Location = new System.Drawing.Point(106, 23);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(124, 19);
            this.NameLbl.TabIndex = 6;
            this.NameLbl.Text = "StudentName";
            // 
            // StuIdLbl
            // 
            this.StuIdLbl.Location = new System.Drawing.Point(23, 23);
            this.StuIdLbl.Name = "StuIdLbl";
            this.StuIdLbl.Size = new System.Drawing.Size(60, 19);
            this.StuIdLbl.TabIndex = 7;
            this.StuIdLbl.Text = "StudentID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1568, 1011);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // CInterGB
            // 
            this.CInterGB.Controls.Add(this.ConRB3);
            this.CInterGB.Controls.Add(this.ConRB1);
            this.CInterGB.Controls.Add(this.ConRB2);
            this.CInterGB.Location = new System.Drawing.Point(9, 272);
            this.CInterGB.Name = "CInterGB";
            this.CInterGB.Size = new System.Drawing.Size(261, 138);
            this.CInterGB.TabIndex = 6;
            this.CInterGB.TabStop = false;
            this.CInterGB.Text = "ControlledIntersections";
            // 
            // ConRB3
            // 
            this.ConRB3.AutoSize = true;
            this.ConRB3.Location = new System.Drawing.Point(15, 97);
            this.ConRB3.Name = "ConRB3";
            this.ConRB3.Size = new System.Drawing.Size(142, 23);
            this.ConRB3.TabIndex = 6;
            this.ConRB3.TabStop = true;
            this.ConRB3.Text = "Unsatisfactory";
            this.ConRB3.UseVisualStyleBackColor = true;
            // 
            // ConRB1
            // 
            this.ConRB1.AutoSize = true;
            this.ConRB1.Location = new System.Drawing.Point(15, 39);
            this.ConRB1.Name = "ConRB1";
            this.ConRB1.Size = new System.Drawing.Size(104, 23);
            this.ConRB1.TabIndex = 4;
            this.ConRB1.TabStop = true;
            this.ConRB1.Text = "Excellent";
            this.ConRB1.UseVisualStyleBackColor = true;
            // 
            // ConRB2
            // 
            this.ConRB2.AutoSize = true;
            this.ConRB2.Location = new System.Drawing.Point(15, 68);
            this.ConRB2.Name = "ConRB2";
            this.ConRB2.Size = new System.Drawing.Size(123, 23);
            this.ConRB2.TabIndex = 5;
            this.ConRB2.TabStop = true;
            this.ConRB2.Text = "Satisfactory";
            this.ConRB2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CInterGB);
            this.groupBox2.Controls.Add(this.CommentsGB);
            this.groupBox2.Controls.Add(this.SNameLbl);
            this.groupBox2.Controls.Add(this.NameLbl);
            this.groupBox2.Controls.Add(this.StuIdLbl);
            this.groupBox2.Controls.Add(this.TestGB);
            this.groupBox2.Controls.Add(this.FreewayGB);
            this.groupBox2.Controls.Add(this.LaneGB);
            this.groupBox2.Controls.Add(this.ParkingGB);
            this.groupBox2.Controls.Add(this.HillGB);
            this.groupBox2.Controls.Add(this.UnInterGB);
            this.groupBox2.Controls.Add(this.DDrivingGB);
            this.groupBox2.Controls.Add(this.SpeedGB);
            this.groupBox2.Controls.Add(this.VehControlGB);
            this.groupBox2.Controls.Add(this.PreGB);
            this.groupBox2.Location = new System.Drawing.Point(6, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1529, 726);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // CommentsGB
            // 
            this.CommentsGB.Controls.Add(this.CommentTxt);
            this.CommentsGB.Location = new System.Drawing.Point(869, 448);
            this.CommentsGB.Name = "CommentsGB";
            this.CommentsGB.Size = new System.Drawing.Size(293, 142);
            this.CommentsGB.TabIndex = 19;
            this.CommentsGB.TabStop = false;
            this.CommentsGB.Text = "Comments";
            // 
            // CommentTxt
            // 
            this.CommentTxt.Location = new System.Drawing.Point(6, 28);
            this.CommentTxt.Multiline = true;
            this.CommentTxt.Name = "CommentTxt";
            this.CommentTxt.Size = new System.Drawing.Size(281, 108);
            this.CommentTxt.TabIndex = 0;
            // 
            // TestGB
            // 
            this.TestGB.Controls.Add(this.TRB3);
            this.TestGB.Controls.Add(this.TRB2);
            this.TestGB.Controls.Add(this.TRB1);
            this.TestGB.Location = new System.Drawing.Point(581, 439);
            this.TestGB.Name = "TestGB";
            this.TestGB.Size = new System.Drawing.Size(261, 157);
            this.TestGB.TabIndex = 18;
            this.TestGB.TabStop = false;
            this.TestGB.Text = "MockTest";
            // 
            // TRB3
            // 
            this.TRB3.AutoSize = true;
            this.TRB3.Location = new System.Drawing.Point(20, 95);
            this.TRB3.Name = "TRB3";
            this.TRB3.Size = new System.Drawing.Size(142, 23);
            this.TRB3.TabIndex = 3;
            this.TRB3.TabStop = true;
            this.TRB3.Text = "Unsatisfactory";
            this.TRB3.UseVisualStyleBackColor = true;
            // 
            // TRB2
            // 
            this.TRB2.AutoSize = true;
            this.TRB2.Location = new System.Drawing.Point(20, 66);
            this.TRB2.Name = "TRB2";
            this.TRB2.Size = new System.Drawing.Size(123, 23);
            this.TRB2.TabIndex = 2;
            this.TRB2.TabStop = true;
            this.TRB2.Text = "Satisfactory";
            this.TRB2.UseVisualStyleBackColor = true;
            // 
            // TRB1
            // 
            this.TRB1.AutoSize = true;
            this.TRB1.Location = new System.Drawing.Point(20, 37);
            this.TRB1.Name = "TRB1";
            this.TRB1.Size = new System.Drawing.Size(104, 23);
            this.TRB1.TabIndex = 1;
            this.TRB1.TabStop = true;
            this.TRB1.Text = "Excellent";
            this.TRB1.UseVisualStyleBackColor = true;
            // 
            // FreewayGB
            // 
            this.FreewayGB.Controls.Add(this.FWRB3);
            this.FreewayGB.Controls.Add(this.FWRB1);
            this.FreewayGB.Controls.Add(this.FWRB2);
            this.FreewayGB.Location = new System.Drawing.Point(313, 448);
            this.FreewayGB.Name = "FreewayGB";
            this.FreewayGB.Size = new System.Drawing.Size(250, 142);
            this.FreewayGB.TabIndex = 17;
            this.FreewayGB.TabStop = false;
            this.FreewayGB.Text = "FreewayDriving";
            // 
            // FWRB3
            // 
            this.FWRB3.AutoSize = true;
            this.FWRB3.Location = new System.Drawing.Point(19, 96);
            this.FWRB3.Name = "FWRB3";
            this.FWRB3.Size = new System.Drawing.Size(142, 23);
            this.FWRB3.TabIndex = 21;
            this.FWRB3.TabStop = true;
            this.FWRB3.Text = "Unsatisfactory";
            this.FWRB3.UseVisualStyleBackColor = true;
            // 
            // FWRB1
            // 
            this.FWRB1.AutoSize = true;
            this.FWRB1.Location = new System.Drawing.Point(19, 38);
            this.FWRB1.Name = "FWRB1";
            this.FWRB1.Size = new System.Drawing.Size(104, 23);
            this.FWRB1.TabIndex = 19;
            this.FWRB1.TabStop = true;
            this.FWRB1.Text = "Excellent";
            this.FWRB1.UseVisualStyleBackColor = true;
            // 
            // FWRB2
            // 
            this.FWRB2.AutoSize = true;
            this.FWRB2.Location = new System.Drawing.Point(19, 67);
            this.FWRB2.Name = "FWRB2";
            this.FWRB2.Size = new System.Drawing.Size(123, 23);
            this.FWRB2.TabIndex = 20;
            this.FWRB2.TabStop = true;
            this.FWRB2.Text = "Satisfactory";
            this.FWRB2.UseVisualStyleBackColor = true;
            // 
            // LaneGB
            // 
            this.LaneGB.Controls.Add(this.LnRB3);
            this.LaneGB.Controls.Add(this.LnRB1);
            this.LaneGB.Controls.Add(this.LnRB2);
            this.LaneGB.Location = new System.Drawing.Point(6, 439);
            this.LaneGB.Name = "LaneGB";
            this.LaneGB.Size = new System.Drawing.Size(280, 151);
            this.LaneGB.TabIndex = 10;
            this.LaneGB.TabStop = false;
            this.LaneGB.Text = "LaneChangingNOvertaking";
            // 
            // LnRB3
            // 
            this.LnRB3.AutoSize = true;
            this.LnRB3.Location = new System.Drawing.Point(18, 96);
            this.LnRB3.Name = "LnRB3";
            this.LnRB3.Size = new System.Drawing.Size(142, 23);
            this.LnRB3.TabIndex = 18;
            this.LnRB3.TabStop = true;
            this.LnRB3.Text = "Unsatisfactory";
            this.LnRB3.UseVisualStyleBackColor = true;
            // 
            // LnRB1
            // 
            this.LnRB1.AutoSize = true;
            this.LnRB1.Location = new System.Drawing.Point(18, 38);
            this.LnRB1.Name = "LnRB1";
            this.LnRB1.Size = new System.Drawing.Size(104, 23);
            this.LnRB1.TabIndex = 16;
            this.LnRB1.TabStop = true;
            this.LnRB1.Text = "Excellent";
            this.LnRB1.UseVisualStyleBackColor = true;
            // 
            // LnRB2
            // 
            this.LnRB2.AutoSize = true;
            this.LnRB2.Location = new System.Drawing.Point(18, 67);
            this.LnRB2.Name = "LnRB2";
            this.LnRB2.Size = new System.Drawing.Size(123, 23);
            this.LnRB2.TabIndex = 17;
            this.LnRB2.TabStop = true;
            this.LnRB2.Text = "Satisfactory";
            this.LnRB2.UseVisualStyleBackColor = true;
            // 
            // ParkingGB
            // 
            this.ParkingGB.Controls.Add(this.ParkRB3);
            this.ParkingGB.Controls.Add(this.ParkRB1);
            this.ParkingGB.Controls.Add(this.ParkRB2);
            this.ParkingGB.Location = new System.Drawing.Point(869, 272);
            this.ParkingGB.Name = "ParkingGB";
            this.ParkingGB.Size = new System.Drawing.Size(293, 151);
            this.ParkingGB.TabIndex = 9;
            this.ParkingGB.TabStop = false;
            this.ParkingGB.Text = "ParkingNReversing";
            // 
            // ParkRB3
            // 
            this.ParkRB3.AutoSize = true;
            this.ParkRB3.Location = new System.Drawing.Point(15, 104);
            this.ParkRB3.Name = "ParkRB3";
            this.ParkRB3.Size = new System.Drawing.Size(142, 23);
            this.ParkRB3.TabIndex = 15;
            this.ParkRB3.TabStop = true;
            this.ParkRB3.Text = "Unsatisfactory";
            this.ParkRB3.UseVisualStyleBackColor = true;
            // 
            // ParkRB1
            // 
            this.ParkRB1.AutoSize = true;
            this.ParkRB1.Location = new System.Drawing.Point(15, 46);
            this.ParkRB1.Name = "ParkRB1";
            this.ParkRB1.Size = new System.Drawing.Size(104, 23);
            this.ParkRB1.TabIndex = 13;
            this.ParkRB1.TabStop = true;
            this.ParkRB1.Text = "Excellent";
            this.ParkRB1.UseVisualStyleBackColor = true;
            // 
            // ParkRB2
            // 
            this.ParkRB2.AutoSize = true;
            this.ParkRB2.Location = new System.Drawing.Point(15, 75);
            this.ParkRB2.Name = "ParkRB2";
            this.ParkRB2.Size = new System.Drawing.Size(123, 23);
            this.ParkRB2.TabIndex = 14;
            this.ParkRB2.TabStop = true;
            this.ParkRB2.Text = "Satisfactory";
            this.ParkRB2.UseVisualStyleBackColor = true;
            // 
            // HillGB
            // 
            this.HillGB.Controls.Add(this.HillRB3);
            this.HillGB.Controls.Add(this.HillRB1);
            this.HillGB.Controls.Add(this.HillRB2);
            this.HillGB.Location = new System.Drawing.Point(576, 272);
            this.HillGB.Name = "HillGB";
            this.HillGB.Size = new System.Drawing.Size(257, 151);
            this.HillGB.TabIndex = 8;
            this.HillGB.TabStop = false;
            this.HillGB.Text = "HillStartsNGradientControl";
            // 
            // HillRB3
            // 
            this.HillRB3.AutoSize = true;
            this.HillRB3.Location = new System.Drawing.Point(10, 104);
            this.HillRB3.Name = "HillRB3";
            this.HillRB3.Size = new System.Drawing.Size(142, 23);
            this.HillRB3.TabIndex = 12;
            this.HillRB3.TabStop = true;
            this.HillRB3.Text = "Unsatisfactory";
            this.HillRB3.UseVisualStyleBackColor = true;
            // 
            // HillRB1
            // 
            this.HillRB1.AutoSize = true;
            this.HillRB1.Location = new System.Drawing.Point(10, 46);
            this.HillRB1.Name = "HillRB1";
            this.HillRB1.Size = new System.Drawing.Size(104, 23);
            this.HillRB1.TabIndex = 10;
            this.HillRB1.TabStop = true;
            this.HillRB1.Text = "Excellent";
            this.HillRB1.UseVisualStyleBackColor = true;
            // 
            // HillRB2
            // 
            this.HillRB2.AutoSize = true;
            this.HillRB2.Location = new System.Drawing.Point(10, 75);
            this.HillRB2.Name = "HillRB2";
            this.HillRB2.Size = new System.Drawing.Size(123, 23);
            this.HillRB2.TabIndex = 11;
            this.HillRB2.TabStop = true;
            this.HillRB2.Text = "Satisfactory";
            this.HillRB2.UseVisualStyleBackColor = true;
            // 
            // UnInterGB
            // 
            this.UnInterGB.Controls.Add(this.UnconRB3);
            this.UnInterGB.Controls.Add(this.UnconRB1);
            this.UnInterGB.Controls.Add(this.UnconRB2);
            this.UnInterGB.Location = new System.Drawing.Point(298, 284);
            this.UnInterGB.Name = "UnInterGB";
            this.UnInterGB.Size = new System.Drawing.Size(252, 126);
            this.UnInterGB.TabIndex = 7;
            this.UnInterGB.TabStop = false;
            this.UnInterGB.Text = "UncontrolledIntersections";
            // 
            // UnconRB3
            // 
            this.UnconRB3.AutoSize = true;
            this.UnconRB3.Location = new System.Drawing.Point(15, 104);
            this.UnconRB3.Name = "UnconRB3";
            this.UnconRB3.Size = new System.Drawing.Size(142, 23);
            this.UnconRB3.TabIndex = 9;
            this.UnconRB3.TabStop = true;
            this.UnconRB3.Text = "Unsatisfactory";
            this.UnconRB3.UseVisualStyleBackColor = true;
            // 
            // UnconRB1
            // 
            this.UnconRB1.AutoSize = true;
            this.UnconRB1.Location = new System.Drawing.Point(15, 46);
            this.UnconRB1.Name = "UnconRB1";
            this.UnconRB1.Size = new System.Drawing.Size(104, 23);
            this.UnconRB1.TabIndex = 7;
            this.UnconRB1.TabStop = true;
            this.UnconRB1.Text = "Excellent";
            this.UnconRB1.UseVisualStyleBackColor = true;
            // 
            // UnconRB2
            // 
            this.UnconRB2.AutoSize = true;
            this.UnconRB2.Location = new System.Drawing.Point(15, 75);
            this.UnconRB2.Name = "UnconRB2";
            this.UnconRB2.Size = new System.Drawing.Size(123, 23);
            this.UnconRB2.TabIndex = 8;
            this.UnconRB2.TabStop = true;
            this.UnconRB2.Text = "Satisfactory";
            this.UnconRB2.UseVisualStyleBackColor = true;
            // 
            // DDrivingGB
            // 
            this.DDrivingGB.Controls.Add(this.DefRB3);
            this.DDrivingGB.Controls.Add(this.DefRB2);
            this.DDrivingGB.Controls.Add(this.DefRB1);
            this.DDrivingGB.Location = new System.Drawing.Point(869, 83);
            this.DDrivingGB.Name = "DDrivingGB";
            this.DDrivingGB.Size = new System.Drawing.Size(293, 149);
            this.DDrivingGB.TabIndex = 5;
            this.DDrivingGB.TabStop = false;
            this.DDrivingGB.Text = "ObservationalNDefensiveDriving";
            // 
            // DefRB3
            // 
            this.DefRB3.AutoSize = true;
            this.DefRB3.Location = new System.Drawing.Point(15, 108);
            this.DefRB3.Name = "DefRB3";
            this.DefRB3.Size = new System.Drawing.Size(142, 23);
            this.DefRB3.TabIndex = 6;
            this.DefRB3.TabStop = true;
            this.DefRB3.Text = "Unsatisfactory";
            this.DefRB3.UseVisualStyleBackColor = true;
            // 
            // DefRB2
            // 
            this.DefRB2.AutoSize = true;
            this.DefRB2.Location = new System.Drawing.Point(15, 79);
            this.DefRB2.Name = "DefRB2";
            this.DefRB2.Size = new System.Drawing.Size(123, 23);
            this.DefRB2.TabIndex = 5;
            this.DefRB2.TabStop = true;
            this.DefRB2.Text = "Satisfactory";
            this.DefRB2.UseVisualStyleBackColor = true;
            // 
            // DefRB1
            // 
            this.DefRB1.AutoSize = true;
            this.DefRB1.Location = new System.Drawing.Point(15, 50);
            this.DefRB1.Name = "DefRB1";
            this.DefRB1.Size = new System.Drawing.Size(104, 23);
            this.DefRB1.TabIndex = 4;
            this.DefRB1.TabStop = true;
            this.DefRB1.Text = "Excellent";
            this.DefRB1.UseVisualStyleBackColor = true;
            // 
            // SpeedGB
            // 
            this.SpeedGB.Controls.Add(this.GearRB3);
            this.SpeedGB.Controls.Add(this.GearRB2);
            this.SpeedGB.Controls.Add(this.GearRB1);
            this.SpeedGB.Location = new System.Drawing.Point(580, 83);
            this.SpeedGB.Name = "SpeedGB";
            this.SpeedGB.Size = new System.Drawing.Size(253, 149);
            this.SpeedGB.TabIndex = 4;
            this.SpeedGB.TabStop = false;
            this.SpeedGB.Text = "SpeedNGearControl";
            // 
            // GearRB3
            // 
            this.GearRB3.AutoSize = true;
            this.GearRB3.Location = new System.Drawing.Point(21, 93);
            this.GearRB3.Name = "GearRB3";
            this.GearRB3.Size = new System.Drawing.Size(142, 23);
            this.GearRB3.TabIndex = 6;
            this.GearRB3.TabStop = true;
            this.GearRB3.Text = "Unsatisfactory";
            this.GearRB3.UseVisualStyleBackColor = true;
            // 
            // GearRB2
            // 
            this.GearRB2.AutoSize = true;
            this.GearRB2.Location = new System.Drawing.Point(21, 64);
            this.GearRB2.Name = "GearRB2";
            this.GearRB2.Size = new System.Drawing.Size(123, 23);
            this.GearRB2.TabIndex = 5;
            this.GearRB2.TabStop = true;
            this.GearRB2.Text = "Satisfactory";
            this.GearRB2.UseVisualStyleBackColor = true;
            // 
            // GearRB1
            // 
            this.GearRB1.AutoSize = true;
            this.GearRB1.Location = new System.Drawing.Point(21, 35);
            this.GearRB1.Name = "GearRB1";
            this.GearRB1.Size = new System.Drawing.Size(104, 23);
            this.GearRB1.TabIndex = 4;
            this.GearRB1.TabStop = true;
            this.GearRB1.Text = "Excellent";
            this.GearRB1.UseVisualStyleBackColor = true;
            // 
            // VehControlGB
            // 
            this.VehControlGB.Controls.Add(this.VRB3);
            this.VehControlGB.Controls.Add(this.VRB2);
            this.VehControlGB.Controls.Add(this.VRB1);
            this.VehControlGB.Location = new System.Drawing.Point(287, 83);
            this.VehControlGB.Name = "VehControlGB";
            this.VehControlGB.Size = new System.Drawing.Size(250, 149);
            this.VehControlGB.TabIndex = 3;
            this.VehControlGB.TabStop = false;
            this.VehControlGB.Text = "VehicleControl";
            // 
            // VRB3
            // 
            this.VRB3.AutoSize = true;
            this.VRB3.Location = new System.Drawing.Point(26, 93);
            this.VRB3.Name = "VRB3";
            this.VRB3.Size = new System.Drawing.Size(142, 23);
            this.VRB3.TabIndex = 6;
            this.VRB3.TabStop = true;
            this.VRB3.Text = "Unsatisfactory";
            this.VRB3.UseVisualStyleBackColor = true;
            // 
            // VRB2
            // 
            this.VRB2.AutoSize = true;
            this.VRB2.Location = new System.Drawing.Point(26, 64);
            this.VRB2.Name = "VRB2";
            this.VRB2.Size = new System.Drawing.Size(123, 23);
            this.VRB2.TabIndex = 5;
            this.VRB2.TabStop = true;
            this.VRB2.Text = "Satisfactory";
            this.VRB2.UseVisualStyleBackColor = true;
            // 
            // VRB1
            // 
            this.VRB1.AutoSize = true;
            this.VRB1.Location = new System.Drawing.Point(26, 35);
            this.VRB1.Name = "VRB1";
            this.VRB1.Size = new System.Drawing.Size(104, 23);
            this.VRB1.TabIndex = 4;
            this.VRB1.TabStop = true;
            this.VRB1.Text = "Excellent";
            this.VRB1.UseVisualStyleBackColor = true;
            // 
            // PreGB
            // 
            this.PreGB.Controls.Add(this.PRB3);
            this.PreGB.Controls.Add(this.PRB2);
            this.PreGB.Controls.Add(this.PRB1);
            this.PreGB.Location = new System.Drawing.Point(9, 73);
            this.PreGB.Name = "PreGB";
            this.PreGB.Size = new System.Drawing.Size(252, 159);
            this.PreGB.TabIndex = 2;
            this.PreGB.TabStop = false;
            this.PreGB.Text = "PreTripChecks";
            // 
            // PRB3
            // 
            this.PRB3.AutoSize = true;
            this.PRB3.Location = new System.Drawing.Point(15, 103);
            this.PRB3.Name = "PRB3";
            this.PRB3.Size = new System.Drawing.Size(142, 23);
            this.PRB3.TabIndex = 6;
            this.PRB3.TabStop = true;
            this.PRB3.Text = "Unsatisfactory";
            this.PRB3.UseVisualStyleBackColor = true;
            // 
            // PRB2
            // 
            this.PRB2.AutoSize = true;
            this.PRB2.Location = new System.Drawing.Point(15, 74);
            this.PRB2.Name = "PRB2";
            this.PRB2.Size = new System.Drawing.Size(123, 23);
            this.PRB2.TabIndex = 5;
            this.PRB2.TabStop = true;
            this.PRB2.Text = "Satisfactory";
            this.PRB2.UseVisualStyleBackColor = true;
            // 
            // PRB1
            // 
            this.PRB1.AutoSize = true;
            this.PRB1.Location = new System.Drawing.Point(15, 45);
            this.PRB1.Name = "PRB1";
            this.PRB1.Size = new System.Drawing.Size(104, 23);
            this.PRB1.TabIndex = 4;
            this.PRB1.TabStop = true;
            this.PRB1.Text = "Excellent";
            this.PRB1.UseVisualStyleBackColor = true;
            // 
            // StudentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1747, 1102);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentSummary";
            this.Text = "StudentSummary";
            this.Load += new System.EventHandler(this.StudentSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.CInterGB.ResumeLayout(false);
            this.CInterGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.CommentsGB.ResumeLayout(false);
            this.CommentsGB.PerformLayout();
            this.TestGB.ResumeLayout(false);
            this.TestGB.PerformLayout();
            this.FreewayGB.ResumeLayout(false);
            this.FreewayGB.PerformLayout();
            this.LaneGB.ResumeLayout(false);
            this.LaneGB.PerformLayout();
            this.ParkingGB.ResumeLayout(false);
            this.ParkingGB.PerformLayout();
            this.HillGB.ResumeLayout(false);
            this.HillGB.PerformLayout();
            this.UnInterGB.ResumeLayout(false);
            this.UnInterGB.PerformLayout();
            this.DDrivingGB.ResumeLayout(false);
            this.DDrivingGB.PerformLayout();
            this.SpeedGB.ResumeLayout(false);
            this.SpeedGB.PerformLayout();
            this.VehControlGB.ResumeLayout(false);
            this.VehControlGB.PerformLayout();
            this.PreGB.ResumeLayout(false);
            this.PreGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DSAttendance2 dsAttendance21;
        private System.Windows.Forms.BindingSource lessonAttendanceMJBindingSource;
        private DSAttendance2TableAdapters.LessonAttendanceMJTableAdapter lessonAttendanceMJTableAdapter;
        private DSAttendance2TableAdapters.StudentProgressTableAdapter studentProgressTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SNameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label StuIdLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox VehControlGB;
        private System.Windows.Forms.GroupBox PreGB;
        private System.Windows.Forms.RadioButton TRB1;
        private System.Windows.Forms.GroupBox TestGB;
        private System.Windows.Forms.RadioButton TRB3;
        private System.Windows.Forms.RadioButton TRB2;
        private System.Windows.Forms.GroupBox FreewayGB;
        private System.Windows.Forms.GroupBox LaneGB;
        private System.Windows.Forms.GroupBox ParkingGB;
        private System.Windows.Forms.GroupBox HillGB;
        private System.Windows.Forms.GroupBox UnInterGB;
        private System.Windows.Forms.GroupBox CInterGB;
        private System.Windows.Forms.GroupBox DDrivingGB;
        private System.Windows.Forms.GroupBox SpeedGB;
        private System.Windows.Forms.RadioButton ConRB3;
        private System.Windows.Forms.RadioButton ConRB1;
        private System.Windows.Forms.RadioButton ConRB2;
        private System.Windows.Forms.GroupBox CommentsGB;
        private System.Windows.Forms.TextBox CommentTxt;
        private System.Windows.Forms.RadioButton FWRB3;
        private System.Windows.Forms.RadioButton FWRB1;
        private System.Windows.Forms.RadioButton FWRB2;
        private System.Windows.Forms.RadioButton LnRB3;
        private System.Windows.Forms.RadioButton LnRB1;
        private System.Windows.Forms.RadioButton LnRB2;
        private System.Windows.Forms.RadioButton ParkRB3;
        private System.Windows.Forms.RadioButton ParkRB1;
        private System.Windows.Forms.RadioButton ParkRB2;
        private System.Windows.Forms.RadioButton HillRB3;
        private System.Windows.Forms.RadioButton HillRB1;
        private System.Windows.Forms.RadioButton HillRB2;
        private System.Windows.Forms.RadioButton UnconRB3;
        private System.Windows.Forms.RadioButton UnconRB1;
        private System.Windows.Forms.RadioButton UnconRB2;
        private System.Windows.Forms.RadioButton DefRB3;
        private System.Windows.Forms.RadioButton DefRB2;
        private System.Windows.Forms.RadioButton DefRB1;
        private System.Windows.Forms.RadioButton GearRB3;
        private System.Windows.Forms.RadioButton GearRB2;
        private System.Windows.Forms.RadioButton GearRB1;
        private System.Windows.Forms.RadioButton VRB3;
        private System.Windows.Forms.RadioButton VRB2;
        private System.Windows.Forms.RadioButton VRB1;
        private System.Windows.Forms.RadioButton PRB3;
        private System.Windows.Forms.RadioButton PRB2;
        private System.Windows.Forms.RadioButton PRB1;
    }
}