
namespace DashboardAS
{
    partial class ViewStaff
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
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mJstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalStaff1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalStaff1 = new DashboardAS.generalStaff();
            this.mJstaffTableAdapter1 = new DashboardAS.generalStaffTableAdapters.MJstaffTableAdapter();
            this.INSERTbtn = new System.Windows.Forms.Button();
            this.UPDATEbtn = new System.Windows.Forms.Button();
            this.ARCHIVEbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sNameTxtB = new System.Windows.Forms.TextBox();
            this.sSurnameTxtB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cellTxtB = new System.Windows.Forms.TextBox();
            this.identityTxtB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.streetNumberTxt = new System.Windows.Forms.TextBox();
            this.streetNameTxtB = new System.Windows.Forms.TextBox();
            this.cityTxtB = new System.Windows.Forms.TextBox();
            this.codeTxtB = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.staffIdTxtB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mJstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalStaff1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalStaff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffSurnameDataGridViewTextBoxColumn,
            this.staffEmailDataGridViewTextBoxColumn,
            this.staffCellNumberDataGridViewTextBoxColumn,
            this.iDNoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.streetNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mJstaffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 143);
            this.dataGridView1.TabIndex = 4;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // staffSurnameDataGridViewTextBoxColumn
            // 
            this.staffSurnameDataGridViewTextBoxColumn.DataPropertyName = "StaffSurname";
            this.staffSurnameDataGridViewTextBoxColumn.HeaderText = "StaffSurname";
            this.staffSurnameDataGridViewTextBoxColumn.Name = "staffSurnameDataGridViewTextBoxColumn";
            // 
            // staffEmailDataGridViewTextBoxColumn
            // 
            this.staffEmailDataGridViewTextBoxColumn.DataPropertyName = "StaffEmail";
            this.staffEmailDataGridViewTextBoxColumn.HeaderText = "StaffEmail";
            this.staffEmailDataGridViewTextBoxColumn.Name = "staffEmailDataGridViewTextBoxColumn";
            // 
            // staffCellNumberDataGridViewTextBoxColumn
            // 
            this.staffCellNumberDataGridViewTextBoxColumn.DataPropertyName = "StaffCellNumber";
            this.staffCellNumberDataGridViewTextBoxColumn.HeaderText = "StaffCellNumber";
            this.staffCellNumberDataGridViewTextBoxColumn.Name = "staffCellNumberDataGridViewTextBoxColumn";
            // 
            // iDNoDataGridViewTextBoxColumn
            // 
            this.iDNoDataGridViewTextBoxColumn.DataPropertyName = "IDNo";
            this.iDNoDataGridViewTextBoxColumn.HeaderText = "IDNo";
            this.iDNoDataGridViewTextBoxColumn.Name = "iDNoDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.HeaderText = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // mJstaffBindingSource
            // 
            this.mJstaffBindingSource.DataMember = "MJstaff";
            this.mJstaffBindingSource.DataSource = this.generalStaff1BindingSource;
            // 
            // generalStaff1BindingSource
            // 
            this.generalStaff1BindingSource.DataSource = this.generalStaff1;
            this.generalStaff1BindingSource.Position = 0;
            // 
            // generalStaff1
            // 
            this.generalStaff1.DataSetName = "generalStaff";
            this.generalStaff1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mJstaffTableAdapter1
            // 
            this.mJstaffTableAdapter1.ClearBeforeFill = true;
            // 
            // INSERTbtn
            // 
            this.INSERTbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.INSERTbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTbtn.Location = new System.Drawing.Point(62, 319);
            this.INSERTbtn.Name = "INSERTbtn";
            this.INSERTbtn.Size = new System.Drawing.Size(106, 32);
            this.INSERTbtn.TabIndex = 15;
            this.INSERTbtn.Text = "INSERT";
            this.INSERTbtn.UseVisualStyleBackColor = false;
            this.INSERTbtn.Click += new System.EventHandler(this.INSERTbtn_Click);
            // 
            // UPDATEbtn
            // 
            this.UPDATEbtn.BackColor = System.Drawing.Color.Yellow;
            this.UPDATEbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtn.Location = new System.Drawing.Point(406, 319);
            this.UPDATEbtn.Name = "UPDATEbtn";
            this.UPDATEbtn.Size = new System.Drawing.Size(106, 32);
            this.UPDATEbtn.TabIndex = 16;
            this.UPDATEbtn.Text = "UPDATE";
            this.UPDATEbtn.UseVisualStyleBackColor = false;
            this.UPDATEbtn.Click += new System.EventHandler(this.UPDATEbtn_Click);
            // 
            // ARCHIVEbtn
            // 
            this.ARCHIVEbtn.BackColor = System.Drawing.Color.Red;
            this.ARCHIVEbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARCHIVEbtn.Location = new System.Drawing.Point(700, 319);
            this.ARCHIVEbtn.Name = "ARCHIVEbtn";
            this.ARCHIVEbtn.Size = new System.Drawing.Size(106, 32);
            this.ARCHIVEbtn.TabIndex = 17;
            this.ARCHIVEbtn.Text = "ARCHIVE";
            this.ARCHIVEbtn.UseVisualStyleBackColor = false;
            this.ARCHIVEbtn.Click += new System.EventHandler(this.ARCHIVEbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Staff Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(670, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Staff Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Staff Cell Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Identity Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Street Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Street Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 285);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(522, 284);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Postal Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(697, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Role";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(843, 281);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Status";
            // 
            // sNameTxtB
            // 
            this.sNameTxtB.Location = new System.Drawing.Point(244, 200);
            this.sNameTxtB.Name = "sNameTxtB";
            this.sNameTxtB.Size = new System.Drawing.Size(137, 20);
            this.sNameTxtB.TabIndex = 30;
            // 
            // sSurnameTxtB
            // 
            this.sSurnameTxtB.Location = new System.Drawing.Point(518, 205);
            this.sSurnameTxtB.Name = "sSurnameTxtB";
            this.sSurnameTxtB.Size = new System.Drawing.Size(137, 20);
            this.sSurnameTxtB.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(753, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 32;
            // 
            // cellTxtB
            // 
            this.cellTxtB.Location = new System.Drawing.Point(137, 245);
            this.cellTxtB.Name = "cellTxtB";
            this.cellTxtB.Size = new System.Drawing.Size(149, 20);
            this.cellTxtB.TabIndex = 33;
            // 
            // identityTxtB
            // 
            this.identityTxtB.Location = new System.Drawing.Point(458, 241);
            this.identityTxtB.Name = "identityTxtB";
            this.identityTxtB.Size = new System.Drawing.Size(149, 20);
            this.identityTxtB.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox1.Location = new System.Drawing.Point(687, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // streetNumberTxt
            // 
            this.streetNumberTxt.Location = new System.Drawing.Point(894, 242);
            this.streetNumberTxt.Name = "streetNumberTxt";
            this.streetNumberTxt.Size = new System.Drawing.Size(49, 20);
            this.streetNumberTxt.TabIndex = 36;
            // 
            // streetNameTxtB
            // 
            this.streetNameTxtB.Location = new System.Drawing.Point(107, 283);
            this.streetNameTxtB.Name = "streetNameTxtB";
            this.streetNameTxtB.Size = new System.Drawing.Size(183, 20);
            this.streetNameTxtB.TabIndex = 37;
            // 
            // cityTxtB
            // 
            this.cityTxtB.Location = new System.Drawing.Point(334, 283);
            this.cityTxtB.Name = "cityTxtB";
            this.cityTxtB.Size = new System.Drawing.Size(183, 20);
            this.cityTxtB.TabIndex = 38;
            // 
            // codeTxtB
            // 
            this.codeTxtB.Location = new System.Drawing.Point(612, 281);
            this.codeTxtB.Name = "codeTxtB";
            this.codeTxtB.Size = new System.Drawing.Size(66, 20);
            this.codeTxtB.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Receptionist",
            "Manager"});
            this.comboBox2.Location = new System.Drawing.Point(733, 277);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Active ",
            "Inactive",
            "Archived"});
            this.comboBox3.Location = new System.Drawing.Point(894, 277);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(106, 21);
            this.comboBox3.TabIndex = 41;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 396);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(745, 150);
            this.dataGridView2.TabIndex = 42;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(31, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 20);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "View Archives";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 204);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "StaffID";
            // 
            // staffIdTxtB
            // 
            this.staffIdTxtB.Location = new System.Drawing.Point(59, 201);
            this.staffIdTxtB.Name = "staffIdTxtB";
            this.staffIdTxtB.Size = new System.Drawing.Size(73, 20);
            this.staffIdTxtB.TabIndex = 45;
            // 
            // ViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 607);
            this.Controls.Add(this.staffIdTxtB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.codeTxtB);
            this.Controls.Add(this.cityTxtB);
            this.Controls.Add(this.streetNameTxtB);
            this.Controls.Add(this.streetNumberTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.identityTxtB);
            this.Controls.Add(this.cellTxtB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sSurnameTxtB);
            this.Controls.Add(this.sNameTxtB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ARCHIVEbtn);
            this.Controls.Add(this.UPDATEbtn);
            this.Controls.Add(this.INSERTbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStaff";
            this.Load += new System.EventHandler(this.ViewStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mJstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalStaff1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalStaff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mJstaffBindingSource;
        private System.Windows.Forms.BindingSource generalStaff1BindingSource;
        private generalStaff generalStaff1;
        private generalStaffTableAdapters.MJstaffTableAdapter mJstaffTableAdapter1;
        private System.Windows.Forms.Button INSERTbtn;
        private System.Windows.Forms.Button UPDATEbtn;
        private System.Windows.Forms.Button ARCHIVEbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sNameTxtB;
        private System.Windows.Forms.TextBox sSurnameTxtB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cellTxtB;
        private System.Windows.Forms.TextBox identityTxtB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox streetNumberTxt;
        private System.Windows.Forms.TextBox streetNameTxtB;
        private System.Windows.Forms.TextBox cityTxtB;
        private System.Windows.Forms.TextBox codeTxtB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox staffIdTxtB;
    }
}