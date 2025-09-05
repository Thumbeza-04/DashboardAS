using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAS
{
    public partial class AttendanceProgress : Form
    {
        private int id;
        public AttendanceProgress(int InstrucId)
        {
            InitializeComponent();
            id = InstrucId;
        }

        private void AttendanceProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAttendance21.StudentProgress' table. You can move, or remove it, as needed.
            //this.studentProgressTableAdapter.Fill(this.dsAttendance21.StudentProgress);
            // TODO: This line of code loads data into the 'dsAttendance21.AttendanceSheet' table. You can move, or remove it, as needed.
            //this.attendanceSheetTableAdapter.Fill(this.dsAttendance21.AttendanceSheet);
            attendanceSheetTableAdapter.FillById(dsAttendance21.AttendanceSheet,id);
            studentProgressTableAdapter.FillByID(dsAttendance21.StudentProgress, id);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int ID = id;
            attendanceSheetTableAdapter.FillByIdName(dsAttendance21.AttendanceSheet,ID, textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int ID = id;
            studentProgressTableAdapter.FillByIdNmae(dsAttendance21.StudentProgress,id, textBox2.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int ID = id;

            attendanceSheetTableAdapter.FillByIdDate(dsAttendance21.AttendanceSheet, ID, dateTimePicker1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
