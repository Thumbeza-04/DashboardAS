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
    public partial class Dash : Form
    {
        public Dash(int id)
        {
            InitializeComponent();
            Lbl.Text = id.ToString();
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            
            //label1.Text = f1.nameTxt.Text;
            lessonBookingMJTableAdapter1.FillByID(dSAttendance.LessonBookingMJ, int.Parse(Lbl.Text));
            
            dtLbl.Text = DateTime.Now.ToShortDateString();

            int count = 0;
            DateTime selectedDate;

            int total = 0;
            if (DateTime.TryParse(dtLbl.Text, out selectedDate))
            {
                int selectedMonth = selectedDate.Month;
                int selectedYear = selectedDate.Year;

                if (DateTime.TryParse(dtLbl.Text, out selectedDate))
                {
                    selectedDate = selectedDate.Date;


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[7].Value != null)
                        {
                            DateTime rowDate;

                            if (DateTime.TryParse(row.Cells[7].Value.ToString(), out rowDate))
                            {
                                if (rowDate.Date == selectedDate)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                        TodayTxt.Text = count.ToString();
                }
                

                int totals = 0;
                if (DateTime.TryParse(dtLbl.Text, out selectedDate))
                {
                    int selectedMonths = selectedDate.Month;
                    int selectedYears = selectedDate.Year;


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if (!row.IsNewRow && row.Cells[7].Value != null)
                        {
                            DateTime rowDate;

                            if (DateTime.TryParse(row.Cells[7].Value.ToString(), out rowDate))
                            {
                                if (rowDate.Month == selectedMonths && rowDate.Year == selectedYears)
                                {
                                    totals++;
                                }
                            }
                        }
                    }
                    monthTxt.Text = totals.ToString();
                }
                
            }
           
            
        }    
    }
}
