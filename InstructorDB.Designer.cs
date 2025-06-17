
namespace DashboardAS
{
    partial class InstructorDB
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.attBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Red;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1067, 100);
            this.topPanel.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Black;
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.attBtn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 100);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(171, 454);
            this.sidePanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(171, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(896, 454);
            this.MainPanel.TabIndex = 2;
            // 
            // attBtn
            // 
            this.attBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.attBtn.ForeColor = System.Drawing.Color.White;
            this.attBtn.Location = new System.Drawing.Point(0, 0);
            this.attBtn.Name = "attBtn";
            this.attBtn.Size = new System.Drawing.Size(171, 46);
            this.attBtn.TabIndex = 0;
            this.attBtn.Text = "Attendance";
            this.attBtn.UseVisualStyleBackColor = false;
            this.attBtn.Click += new System.EventHandler(this.attBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Students";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InstructorDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InstructorDB";
            this.Text = "InstructorDB";
            this.Load += new System.EventHandler(this.InstructorDB_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button attBtn;
    }
}