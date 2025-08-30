
namespace DashboardAS
{
    partial class ViewInstructors
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertiseLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerDataSet1 = new DashboardAS.managerDataSet();
            this.instructorIDtxtB = new System.Windows.Forms.TextBox();
            this.instructorMJTableAdapter1 = new DashboardAS.managerDataSetTableAdapters.InstructorMJTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.licenseNotxtB = new System.Windows.Forms.TextBox();
            this.firstNameTxtB = new System.Windows.Forms.TextBox();
            this.LastnametxtB = new System.Windows.Forms.TextBox();
            this.contactNumberTxtB = new System.Windows.Forms.TextBox();
            this.emailTxtB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instructorsVehicles1 = new DashboardAS.instructorsVehicles();
            this.instructorsVehicles1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleMJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleMJTableAdapter = new DashboardAS.instructorsVehiclesTableAdapters.VehicleMJTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.instructorMJBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorMJTableAdapter = new DashboardAS.instructorsVehiclesTableAdapters.InstructorMJTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.INSERTbtn = new System.Windows.Forms.Button();
            this.UPDATEbtn = new System.Windows.Forms.Button();
            this.ARCHIVEbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsVehicles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsVehicles1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorMJBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instructor List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructorIDDataGridViewTextBoxColumn,
            this.licensePlateIDDataGridViewTextBoxColumn,
            this.licenseNumberDataGridViewTextBoxColumn,
            this.expertiseLevelDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorMJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 138);
            this.dataGridView1.TabIndex = 2;
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            this.instructorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // licensePlateIDDataGridViewTextBoxColumn
            // 
            this.licensePlateIDDataGridViewTextBoxColumn.DataPropertyName = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn.HeaderText = "LicensePlateID";
            this.licensePlateIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licensePlateIDDataGridViewTextBoxColumn.Name = "licensePlateIDDataGridViewTextBoxColumn";
            this.licensePlateIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            this.licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.HeaderText = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            this.licenseNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // expertiseLevelDataGridViewTextBoxColumn
            // 
            this.expertiseLevelDataGridViewTextBoxColumn.DataPropertyName = "ExpertiseLevel";
            this.expertiseLevelDataGridViewTextBoxColumn.HeaderText = "ExpertiseLevel";
            this.expertiseLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expertiseLevelDataGridViewTextBoxColumn.Name = "expertiseLevelDataGridViewTextBoxColumn";
            this.expertiseLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructorMJBindingSource
            // 
            this.instructorMJBindingSource.DataMember = "InstructorMJ";
            this.instructorMJBindingSource.DataSource = this.managerDataSet1;
            // 
            // managerDataSet1
            // 
            this.managerDataSet1.DataSetName = "managerDataSet";
            this.managerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorIDtxtB
            // 
            this.instructorIDtxtB.Location = new System.Drawing.Point(96, 219);
            this.instructorIDtxtB.Margin = new System.Windows.Forms.Padding(2);
            this.instructorIDtxtB.Name = "instructorIDtxtB";
            this.instructorIDtxtB.Size = new System.Drawing.Size(70, 20);
            this.instructorIDtxtB.TabIndex = 3;
            this.instructorIDtxtB.TextChanged += new System.EventHandler(this.searchinstructorsbox_TextChanged);
            // 
            // instructorMJTableAdapter1
            // 
            this.instructorMJTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "InstructorID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "License Plate ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "License Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(686, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Expertise Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(686, 260);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            // 
            // licenseNotxtB
            // 
            this.licenseNotxtB.Location = new System.Drawing.Point(540, 219);
            this.licenseNotxtB.Margin = new System.Windows.Forms.Padding(2);
            this.licenseNotxtB.Name = "licenseNotxtB";
            this.licenseNotxtB.Size = new System.Drawing.Size(126, 20);
            this.licenseNotxtB.TabIndex = 13;
            // 
            // firstNameTxtB
            // 
            this.firstNameTxtB.Location = new System.Drawing.Point(91, 257);
            this.firstNameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTxtB.Name = "firstNameTxtB";
            this.firstNameTxtB.Size = new System.Drawing.Size(130, 20);
            this.firstNameTxtB.TabIndex = 14;
            // 
            // LastnametxtB
            // 
            this.LastnametxtB.Location = new System.Drawing.Point(315, 259);
            this.LastnametxtB.Margin = new System.Windows.Forms.Padding(2);
            this.LastnametxtB.Name = "LastnametxtB";
            this.LastnametxtB.Size = new System.Drawing.Size(138, 20);
            this.LastnametxtB.TabIndex = 15;
            // 
            // contactNumberTxtB
            // 
            this.contactNumberTxtB.Location = new System.Drawing.Point(805, 260);
            this.contactNumberTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.contactNumberTxtB.Name = "contactNumberTxtB";
            this.contactNumberTxtB.Size = new System.Drawing.Size(138, 20);
            this.contactNumberTxtB.TabIndex = 16;
            // 
            // emailTxtB
            // 
            this.emailTxtB.Location = new System.Drawing.Point(59, 293);
            this.emailTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.emailTxtB.Name = "emailTxtB";
            this.emailTxtB.Size = new System.Drawing.Size(138, 20);
            this.emailTxtB.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehicleMJBindingSource, "LicensePlateID", true));
            this.comboBox1.DataSource = this.vehicleMJBindingSource;
            this.comboBox1.DisplayMember = "LicensePlateID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "LicensePlateID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // instructorsVehicles1
            // 
            this.instructorsVehicles1.DataSetName = "instructorsVehicles";
            this.instructorsVehicles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorsVehicles1BindingSource
            // 
            this.instructorsVehicles1BindingSource.DataSource = this.instructorsVehicles1;
            this.instructorsVehicles1BindingSource.Position = 0;
            // 
            // vehicleMJBindingSource
            // 
            this.vehicleMJBindingSource.DataMember = "VehicleMJ";
            this.vehicleMJBindingSource.DataSource = this.instructorsVehicles1BindingSource;
            // 
            // vehicleMJTableAdapter
            // 
            this.vehicleMJTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehicleMJBindingSource, "LicensePlateID", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Intermediate",
            "Senior"});
            this.comboBox2.Location = new System.Drawing.Point(794, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // instructorMJBindingSource1
            // 
            this.instructorMJBindingSource1.DataMember = "InstructorMJ";
            this.instructorMJBindingSource1.DataSource = this.instructorsVehicles1BindingSource;
            // 
            // instructorMJTableAdapter
            // 
            this.instructorMJTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox3.Location = new System.Drawing.Point(540, 257);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // INSERTbtn
            // 
            this.INSERTbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.INSERTbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTbtn.Location = new System.Drawing.Point(96, 341);
            this.INSERTbtn.Name = "INSERTbtn";
            this.INSERTbtn.Size = new System.Drawing.Size(106, 32);
            this.INSERTbtn.TabIndex = 21;
            this.INSERTbtn.Text = "INSERT";
            this.INSERTbtn.UseVisualStyleBackColor = false;
            this.INSERTbtn.Click += new System.EventHandler(this.INSERTbtn_Click);
            // 
            // UPDATEbtn
            // 
            this.UPDATEbtn.BackColor = System.Drawing.Color.Yellow;
            this.UPDATEbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtn.Location = new System.Drawing.Point(482, 341);
            this.UPDATEbtn.Name = "UPDATEbtn";
            this.UPDATEbtn.Size = new System.Drawing.Size(106, 32);
            this.UPDATEbtn.TabIndex = 22;
            this.UPDATEbtn.Text = "UPDATE";
            this.UPDATEbtn.UseVisualStyleBackColor = false;
            this.UPDATEbtn.Click += new System.EventHandler(this.UPDATEbtn_Click);
            // 
            // ARCHIVEbtn
            // 
            this.ARCHIVEbtn.BackColor = System.Drawing.Color.Red;
            this.ARCHIVEbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARCHIVEbtn.Location = new System.Drawing.Point(805, 341);
            this.ARCHIVEbtn.Name = "ARCHIVEbtn";
            this.ARCHIVEbtn.Size = new System.Drawing.Size(106, 32);
            this.ARCHIVEbtn.TabIndex = 23;
            this.ARCHIVEbtn.Text = "ARCHIVE";
            this.ARCHIVEbtn.UseVisualStyleBackColor = false;
            // 
            // ViewInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 517);
            this.Controls.Add(this.ARCHIVEbtn);
            this.Controls.Add(this.UPDATEbtn);
            this.Controls.Add(this.INSERTbtn);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.emailTxtB);
            this.Controls.Add(this.contactNumberTxtB);
            this.Controls.Add(this.LastnametxtB);
            this.Controls.Add(this.firstNameTxtB);
            this.Controls.Add(this.licenseNotxtB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructorIDtxtB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInstructors";
            this.Load += new System.EventHandler(this.ViewInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsVehicles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsVehicles1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorMJBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox instructorIDtxtB;
        private managerDataSet managerDataSet1;
        private managerDataSetTableAdapters.InstructorMJTableAdapter instructorMJTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertiseLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource instructorMJBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox licenseNotxtB;
        private System.Windows.Forms.TextBox firstNameTxtB;
        private System.Windows.Forms.TextBox LastnametxtB;
        private System.Windows.Forms.TextBox contactNumberTxtB;
        private System.Windows.Forms.TextBox emailTxtB;
        private System.Windows.Forms.ComboBox comboBox1;
        private instructorsVehicles instructorsVehicles1;
        private System.Windows.Forms.BindingSource instructorsVehicles1BindingSource;
        private System.Windows.Forms.BindingSource vehicleMJBindingSource;
        private instructorsVehiclesTableAdapters.VehicleMJTableAdapter vehicleMJTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource instructorMJBindingSource1;
        private instructorsVehiclesTableAdapters.InstructorMJTableAdapter instructorMJTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button INSERTbtn;
        private System.Windows.Forms.Button UPDATEbtn;
        private System.Windows.Forms.Button ARCHIVEbtn;
    }
}