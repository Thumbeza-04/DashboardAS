using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DashboardAS
{
    public partial class Dash : Form
    {
        private int Id;
        public Dash(int id)
        {
            InitializeComponent();
            Id = id;
        }
        SqlConnection connec = new SqlConnection("Data Source=146.230.177.46;User ID=WstGrp24;Password=6wefi");

        private void Dash_Load(object sender, EventArgs e)
        {
            connec.Open();
            SqlCommand command = new SqlCommand("SELECT FirstName FROM InstructorMJ WHERE InstructorID = @InstructorID", connec);
            command.Parameters.AddWithValue("@InstructorID", Id);

            object result = command.ExecuteScalar();

            

            if (result != null)
            {
                
                label4.Text = $"Welcome back, {result.ToString()}!";
            }
            connec.Close();
            
            //label1.Text = f1.nameTxt.Text;
            lessonBookingMJTableAdapter1.FillByID(dSAttendance.LessonBookingMJ, Id);

            int count = 0;
            DateTime selectedDate;
            if (DateTime.TryParse(dateTimePicker1.Value.ToString(), out selectedDate))
            {
                selectedDate = selectedDate.Date;


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[5].Value != null)
                    {
                        DateTime rowDate;

                        if (DateTime.TryParse(row.Cells[5].Value.ToString(), out rowDate))
                        {
                            if (rowDate.Date == selectedDate)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            TodayTxt.Text = count.ToString();

            int total = 0;
            if (DateTime.TryParse(dateTimePicker1.Value.ToString(), out selectedDate))
            {
                int selectedMonth = selectedDate.Month;
                int selectedYear = selectedDate.Year;


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (!row.IsNewRow && row.Cells[5].Value != null)
                    {
                        DateTime rowDate;

                        if (DateTime.TryParse(row.Cells[5].Value.ToString(), out rowDate))
                        {
                            if (rowDate.Month == selectedMonth && rowDate.Year == selectedYear)
                            {
                                total++;
                            }
                        }
                    }
                }
            }
            monthTxt.Text = total.ToString();

            int ST = 0;
            HashSet<int> Students = new HashSet<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                object CV = row.Cells[1].Value;
                if (CV != null && int.TryParse(CV.ToString(), out int SD))
                {
                    if (Students.Add(SD)) 
                    {
                        ST++;
                    }
                }
            }

            StudentTxt.Text = ST.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lessonBookingMJTableAdapter1.FillByIDate(dSAttendance.LessonBookingMJ,Id, dateTimePicker1.Text);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TodayTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
