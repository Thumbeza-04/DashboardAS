
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommentBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RatingsBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.studentProgressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAttendance2 = new DashboardAS.DSAttendance2();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAttendance21 = new DashboardAS.DSAttendance2();
            this.studentProgressTableAdapter1 = new DashboardAS.DSAttendance2TableAdapters.StudentProgressTableAdapter();
            this.studentMJTableAdapter = new DashboardAS.DSAttendance2TableAdapters.StudentMJTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1165, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by Student Name\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1424, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.packageNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentMJBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 72);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1528, 148);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CommentBtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.RatingsBtn);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 291);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1568, 564);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evatuation";
            // 
            // CommentBtn
            // 
            this.CommentBtn.Location = new System.Drawing.Point(667, 429);
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.Size = new System.Drawing.Size(175, 32);
            this.CommentBtn.TabIndex = 5;
            this.CommentBtn.Text = "Submit Comment";
            this.CommentBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 230);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 170);
            this.textBox2.TabIndex = 4;
            // 
            // RatingsBtn
            // 
            this.RatingsBtn.Location = new System.Drawing.Point(20, 278);
            this.RatingsBtn.Name = "RatingsBtn";
            this.RatingsBtn.Size = new System.Drawing.Size(183, 39);
            this.RatingsBtn.TabIndex = 3;
            this.RatingsBtn.Text = "Submit Rating";
            this.RatingsBtn.UseVisualStyleBackColor = true;
            this.RatingsBtn.Click += new System.EventHandler(this.RatingsBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Excellent",
            "Satisfactory",
            "Unsatisfactory"});
            this.comboBox2.Location = new System.Drawing.Point(221, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PreTripChecks",
            "VehicleControl",
            "SpeedNGearControl",
            "ObservationalNDefensiveDriving",
            "ControlledIntersections",
            "UncontrolledIntersections",
            "HillStartsNGradientControl",
            "ParkingNReversing",
            "LaneChangingNOvertaking",
            "FreewayDriving",
            "MockTest"});
            this.comboBox1.Location = new System.Drawing.Point(20, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn1,
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1515, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "*Double click the row to evaluate student";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(2, 225);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(177, 32);
            this.AddBtn.TabIndex = 28;
            this.AddBtn.Text = "Add to evaluation";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.vehicleControlDataGridViewTextBoxColumn.DataPropertyName = "VehicleControl";
            this.vehicleControlDataGridViewTextBoxColumn.HeaderText = "VehicleControl";
            this.vehicleControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleControlDataGridViewTextBoxColumn.Name = "vehicleControlDataGridViewTextBoxColumn";
            this.vehicleControlDataGridViewTextBoxColumn.Width = 125;
            // 
            // speedNGearControlDataGridViewTextBoxColumn
            // 
            this.speedNGearControlDataGridViewTextBoxColumn.DataPropertyName = "SpeedNGearControl";
            this.speedNGearControlDataGridViewTextBoxColumn.HeaderText = "SpeedNGearControl";
            this.speedNGearControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speedNGearControlDataGridViewTextBoxColumn.Name = "speedNGearControlDataGridViewTextBoxColumn";
            this.speedNGearControlDataGridViewTextBoxColumn.Width = 125;
            // 
            // observationalNDefensiveDrivingDataGridViewTextBoxColumn
            // 
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.DataPropertyName = "ObservationalNDefensiveDriving";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.HeaderText = "ObservationalNDefensiveDriving";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.Name = "observationalNDefensiveDrivingDataGridViewTextBoxColumn";
            this.observationalNDefensiveDrivingDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlledIntersectionsDataGridViewTextBoxColumn
            // 
            this.controlledIntersectionsDataGridViewTextBoxColumn.DataPropertyName = "ControlledIntersections";
            this.controlledIntersectionsDataGridViewTextBoxColumn.HeaderText = "ControlledIntersections";
            this.controlledIntersectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlledIntersectionsDataGridViewTextBoxColumn.Name = "controlledIntersectionsDataGridViewTextBoxColumn";
            this.controlledIntersectionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // uncontrolledIntersectionsDataGridViewTextBoxColumn
            // 
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.DataPropertyName = "UncontrolledIntersections";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.HeaderText = "UncontrolledIntersections";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.Name = "uncontrolledIntersectionsDataGridViewTextBoxColumn";
            this.uncontrolledIntersectionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // hillStartsNGradientControlDataGridViewTextBoxColumn
            // 
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.DataPropertyName = "HillStartsNGradientControl";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.HeaderText = "HillStartsNGradientControl";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.Name = "hillStartsNGradientControlDataGridViewTextBoxColumn";
            this.hillStartsNGradientControlDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingNReversingDataGridViewTextBoxColumn
            // 
            this.parkingNReversingDataGridViewTextBoxColumn.DataPropertyName = "ParkingNReversing";
            this.parkingNReversingDataGridViewTextBoxColumn.HeaderText = "ParkingNReversing";
            this.parkingNReversingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingNReversingDataGridViewTextBoxColumn.Name = "parkingNReversingDataGridViewTextBoxColumn";
            this.parkingNReversingDataGridViewTextBoxColumn.Width = 125;
            // 
            // laneChangingNOvertakingDataGridViewTextBoxColumn
            // 
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.DataPropertyName = "LaneChangingNOvertaking";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.HeaderText = "LaneChangingNOvertaking";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.Name = "laneChangingNOvertakingDataGridViewTextBoxColumn";
            this.laneChangingNOvertakingDataGridViewTextBoxColumn.Width = 125;
            // 
            // freewayDrivingDataGridViewTextBoxColumn
            // 
            this.freewayDrivingDataGridViewTextBoxColumn.DataPropertyName = "FreewayDriving";
            this.freewayDrivingDataGridViewTextBoxColumn.HeaderText = "FreewayDriving";
            this.freewayDrivingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freewayDrivingDataGridViewTextBoxColumn.Name = "freewayDrivingDataGridViewTextBoxColumn";
            this.freewayDrivingDataGridViewTextBoxColumn.Width = 125;
            // 
            // mockTestDataGridViewTextBoxColumn
            // 
            this.mockTestDataGridViewTextBoxColumn.DataPropertyName = "MockTest";
            this.mockTestDataGridViewTextBoxColumn.HeaderText = "MockTest";
            this.mockTestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mockTestDataGridViewTextBoxColumn.Name = "mockTestDataGridViewTextBoxColumn";
            this.mockTestDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentProgressBindingSource
            // 
            this.studentProgressBindingSource.DataMember = "StudentProgress";
            this.studentProgressBindingSource.DataSource = this.dSAttendance2;
            // 
            // dSAttendance2
            // 
            this.dSAttendance2.DataSetName = "DSAttendance2";
            this.dSAttendance2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // packageNameDataGridViewTextBoxColumn
            // 
            this.packageNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            this.packageNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentMJBindingSource
            // 
            this.studentMJBindingSource.DataMember = "StudentMJ";
            this.studentMJBindingSource.DataSource = this.dSAttendance2;
            // 
            // dsAttendance21
            // 
            this.dsAttendance21.DataSetName = "DSAttendance2";
            this.dsAttendance21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentProgressTableAdapter1
            // 
            this.studentProgressTableAdapter1.ClearBeforeFill = true;
            // 
            // studentMJTableAdapter
            // 
            this.studentMJTableAdapter.ClearBeforeFill = true;
            // 
            // StudentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1746, 1102);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentSummary";
            this.Text = "StudentSummary";
            this.Load += new System.EventHandler(this.StudentSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProgressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAttendance2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttendance21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DSAttendance2 dsAttendance21;
//        private DSAttendance2TableAdapters./LessonAttendanceMJTableAdapter lessonAttendanceMJTableAdapter;
        private DSAttendance2TableAdapters.StudentProgressTableAdapter studentProgressTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CommentBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button RatingsBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DSAttendance2 dSAttendance2;
        private System.Windows.Forms.BindingSource studentMJBindingSource;
        private DSAttendance2TableAdapters.StudentMJTableAdapter studentMJTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentProgressBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
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