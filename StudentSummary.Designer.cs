
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfLessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonAttendanceMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.SNameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.StuIdLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.CInterGB = new System.Windows.Forms.GroupBox();
            this.ConRB3 = new System.Windows.Forms.RadioButton();
            this.ConRB1 = new System.Windows.Forms.RadioButton();
            this.ConRB2 = new System.Windows.Forms.RadioButton();
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
            this.lessonAttendanceMJTableAdapter = new DashboardAS.DSAttendance2TableAdapters.LessonAttendanceMJTableAdapter();
            this.studentProgressTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.StudentProgressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CInterGB.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1019, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Student Name\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1246, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.numberOfLessonsDataGridViewTextBoxColumn,
            this.remainingDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lessonAttendanceMJBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 50);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1337, 148);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // numberOfLessonsDataGridViewTextBoxColumn
            // 
            this.numberOfLessonsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfLessonsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfLessons";
            this.numberOfLessonsDataGridViewTextBoxColumn.HeaderText = "NumberOfLessons";
            this.numberOfLessonsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfLessonsDataGridViewTextBoxColumn.Name = "numberOfLessonsDataGridViewTextBoxColumn";
            // 
            // remainingDataGridViewTextBoxColumn
            // 
            this.remainingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining";
            this.remainingDataGridViewTextBoxColumn.HeaderText = "Remaining";
            this.remainingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remainingDataGridViewTextBoxColumn.Name = "remainingDataGridViewTextBoxColumn";
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
            // SNameLbl
            // 
            this.SNameLbl.Location = new System.Drawing.Point(225, 23);
            this.SNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SNameLbl.Name = "SNameLbl";
            this.SNameLbl.Size = new System.Drawing.Size(139, 19);
            this.SNameLbl.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.Location = new System.Drawing.Point(92, 23);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(108, 19);
            this.NameLbl.TabIndex = 6;
            // 
            // StuIdLbl
            // 
            this.StuIdLbl.Location = new System.Drawing.Point(20, 23);
            this.StuIdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StuIdLbl.Name = "StuIdLbl";
            this.StuIdLbl.Size = new System.Drawing.Size(52, 19);
            this.StuIdLbl.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1372, 1006);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evatuation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "*Double click the row to evaluate student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Savebtn);
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
            this.groupBox2.Location = new System.Drawing.Point(5, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(1337, 711);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.YellowGreen;
            this.Savebtn.Location = new System.Drawing.Point(1017, 541);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(135, 43);
            this.Savebtn.TabIndex = 21;
            this.Savebtn.Text = "Save Comment";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // CInterGB
            // 
            this.CInterGB.Controls.Add(this.ConRB3);
            this.CInterGB.Controls.Add(this.ConRB1);
            this.CInterGB.Controls.Add(this.ConRB2);
            this.CInterGB.Location = new System.Drawing.Point(1049, 94);
            this.CInterGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CInterGB.Name = "CInterGB";
            this.CInterGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CInterGB.Size = new System.Drawing.Size(228, 138);
            this.CInterGB.TabIndex = 6;
            this.CInterGB.TabStop = false;
            this.CInterGB.Text = "Controlled Intersections";
            // 
            // ConRB3
            // 
            this.ConRB3.AutoSize = true;
            this.ConRB3.Location = new System.Drawing.Point(13, 97);
            this.ConRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ConRB1.Location = new System.Drawing.Point(13, 39);
            this.ConRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ConRB2.Location = new System.Drawing.Point(13, 68);
            this.ConRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ConRB2.Name = "ConRB2";
            this.ConRB2.Size = new System.Drawing.Size(123, 23);
            this.ConRB2.TabIndex = 5;
            this.ConRB2.TabStop = true;
            this.ConRB2.Text = "Satisfactory";
            this.ConRB2.UseVisualStyleBackColor = true;
            // 
            // CommentsGB
            // 
            this.CommentsGB.Controls.Add(this.CommentTxt);
            this.CommentsGB.Location = new System.Drawing.Point(251, 427);
            this.CommentsGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommentsGB.Name = "CommentsGB";
            this.CommentsGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommentsGB.Size = new System.Drawing.Size(754, 157);
            this.CommentsGB.TabIndex = 19;
            this.CommentsGB.TabStop = false;
            this.CommentsGB.Text = "Comments";
            // 
            // CommentTxt
            // 
            this.CommentTxt.Location = new System.Drawing.Point(5, 28);
            this.CommentTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CommentTxt.Multiline = true;
            this.CommentTxt.Name = "CommentTxt";
            this.CommentTxt.Size = new System.Drawing.Size(744, 123);
            this.CommentTxt.TabIndex = 0;
            // 
            // TestGB
            // 
            this.TestGB.Controls.Add(this.TRB3);
            this.TestGB.Controls.Add(this.TRB2);
            this.TestGB.Controls.Add(this.TRB1);
            this.TestGB.Location = new System.Drawing.Point(2, 427);
            this.TestGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestGB.Name = "TestGB";
            this.TestGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestGB.Size = new System.Drawing.Size(228, 157);
            this.TestGB.TabIndex = 18;
            this.TestGB.TabStop = false;
            this.TestGB.Text = "Mock Test";
            // 
            // TRB3
            // 
            this.TRB3.AutoSize = true;
            this.TRB3.Location = new System.Drawing.Point(17, 95);
            this.TRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.TRB2.Location = new System.Drawing.Point(17, 66);
            this.TRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.TRB1.Location = new System.Drawing.Point(17, 37);
            this.TRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.FreewayGB.Location = new System.Drawing.Point(1049, 265);
            this.FreewayGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FreewayGB.Name = "FreewayGB";
            this.FreewayGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FreewayGB.Size = new System.Drawing.Size(218, 142);
            this.FreewayGB.TabIndex = 17;
            this.FreewayGB.TabStop = false;
            this.FreewayGB.Text = "Freeway Driving";
            // 
            // FWRB3
            // 
            this.FWRB3.AutoSize = true;
            this.FWRB3.Location = new System.Drawing.Point(16, 96);
            this.FWRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.FWRB1.Location = new System.Drawing.Point(16, 38);
            this.FWRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.FWRB2.Location = new System.Drawing.Point(16, 67);
            this.FWRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.LaneGB.Location = new System.Drawing.Point(760, 256);
            this.LaneGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LaneGB.Name = "LaneGB";
            this.LaneGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LaneGB.Size = new System.Drawing.Size(245, 151);
            this.LaneGB.TabIndex = 10;
            this.LaneGB.TabStop = false;
            this.LaneGB.Text = "Lane Changing N Overtaking";
            // 
            // LnRB3
            // 
            this.LnRB3.AutoSize = true;
            this.LnRB3.Location = new System.Drawing.Point(15, 96);
            this.LnRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.LnRB1.Location = new System.Drawing.Point(15, 38);
            this.LnRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.LnRB2.Location = new System.Drawing.Point(15, 67);
            this.LnRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ParkingGB.Location = new System.Drawing.Point(508, 256);
            this.ParkingGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ParkingGB.Name = "ParkingGB";
            this.ParkingGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ParkingGB.Size = new System.Drawing.Size(220, 151);
            this.ParkingGB.TabIndex = 9;
            this.ParkingGB.TabStop = false;
            this.ParkingGB.Text = "Parking N Reversing";
            // 
            // ParkRB3
            // 
            this.ParkRB3.AutoSize = true;
            this.ParkRB3.Location = new System.Drawing.Point(13, 104);
            this.ParkRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ParkRB1.Location = new System.Drawing.Point(13, 46);
            this.ParkRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.ParkRB2.Location = new System.Drawing.Point(13, 75);
            this.ParkRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.HillGB.Location = new System.Drawing.Point(251, 256);
            this.HillGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HillGB.Name = "HillGB";
            this.HillGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HillGB.Size = new System.Drawing.Size(224, 151);
            this.HillGB.TabIndex = 8;
            this.HillGB.TabStop = false;
            this.HillGB.Text = "Hill Starts N Gradient Control";
            // 
            // HillRB3
            // 
            this.HillRB3.AutoSize = true;
            this.HillRB3.Location = new System.Drawing.Point(8, 104);
            this.HillRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.HillRB1.Location = new System.Drawing.Point(8, 46);
            this.HillRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.HillRB2.Location = new System.Drawing.Point(8, 75);
            this.HillRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.UnInterGB.Location = new System.Drawing.Point(7, 256);
            this.UnInterGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UnInterGB.Name = "UnInterGB";
            this.UnInterGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UnInterGB.Size = new System.Drawing.Size(220, 151);
            this.UnInterGB.TabIndex = 7;
            this.UnInterGB.TabStop = false;
            this.UnInterGB.Text = "Uncontrolled Intersections";
            // 
            // UnconRB3
            // 
            this.UnconRB3.AutoSize = true;
            this.UnconRB3.Location = new System.Drawing.Point(13, 104);
            this.UnconRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.UnconRB1.Location = new System.Drawing.Point(13, 46);
            this.UnconRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.UnconRB2.Location = new System.Drawing.Point(13, 75);
            this.UnconRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.DDrivingGB.Location = new System.Drawing.Point(760, 83);
            this.DDrivingGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DDrivingGB.Name = "DDrivingGB";
            this.DDrivingGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DDrivingGB.Size = new System.Drawing.Size(256, 149);
            this.DDrivingGB.TabIndex = 5;
            this.DDrivingGB.TabStop = false;
            this.DDrivingGB.Text = "Observational N Defensive Driving";
            // 
            // DefRB3
            // 
            this.DefRB3.AutoSize = true;
            this.DefRB3.Location = new System.Drawing.Point(13, 108);
            this.DefRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.DefRB2.Location = new System.Drawing.Point(13, 79);
            this.DefRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.DefRB1.Location = new System.Drawing.Point(13, 50);
            this.DefRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.SpeedGB.Location = new System.Drawing.Point(507, 83);
            this.SpeedGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SpeedGB.Name = "SpeedGB";
            this.SpeedGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SpeedGB.Size = new System.Drawing.Size(221, 149);
            this.SpeedGB.TabIndex = 4;
            this.SpeedGB.TabStop = false;
            this.SpeedGB.Text = "Speed N Gear Control";
            // 
            // GearRB3
            // 
            this.GearRB3.AutoSize = true;
            this.GearRB3.Location = new System.Drawing.Point(18, 93);
            this.GearRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.GearRB2.Location = new System.Drawing.Point(18, 64);
            this.GearRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.GearRB1.Location = new System.Drawing.Point(18, 35);
            this.GearRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.VehControlGB.Location = new System.Drawing.Point(251, 83);
            this.VehControlGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VehControlGB.Name = "VehControlGB";
            this.VehControlGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VehControlGB.Size = new System.Drawing.Size(218, 149);
            this.VehControlGB.TabIndex = 3;
            this.VehControlGB.TabStop = false;
            this.VehControlGB.Text = "Vehicle Control";
            // 
            // VRB3
            // 
            this.VRB3.AutoSize = true;
            this.VRB3.Location = new System.Drawing.Point(22, 93);
            this.VRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.VRB2.Location = new System.Drawing.Point(22, 64);
            this.VRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.VRB1.Location = new System.Drawing.Point(22, 35);
            this.VRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.PreGB.Location = new System.Drawing.Point(7, 73);
            this.PreGB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PreGB.Name = "PreGB";
            this.PreGB.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PreGB.Size = new System.Drawing.Size(220, 159);
            this.PreGB.TabIndex = 2;
            this.PreGB.TabStop = false;
            this.PreGB.Text = "PreTrip Checks";
            // 
            // PRB3
            // 
            this.PRB3.AutoSize = true;
            this.PRB3.Location = new System.Drawing.Point(13, 103);
            this.PRB3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.PRB2.Location = new System.Drawing.Point(13, 74);
            this.PRB2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.PRB1.Location = new System.Drawing.Point(13, 45);
            this.PRB1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PRB1.Name = "PRB1";
            this.PRB1.Size = new System.Drawing.Size(104, 23);
            this.PRB1.TabIndex = 4;
            this.PRB1.TabStop = true;
            this.PRB1.Text = "Excellent";
            this.PRB1.UseVisualStyleBackColor = true;
            this.PRB1.CheckedChanged += new System.EventHandler(this.PRB1_CheckedChanged);
            // 
            // lessonAttendanceMJTableAdapter
            // 
            this.lessonAttendanceMJTableAdapter.ClearBeforeFill = true;
            // 
            // studentProgressTableAdapter1
            // 
            this.studentProgressTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1528, 1102);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentSummary";
            this.Text = "StudentSummary";
            this.Load += new System.EventHandler(this.StudentSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttendanceMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.CInterGB.ResumeLayout(false);
            this.CInterGB.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfLessonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Savebtn;
    }
}