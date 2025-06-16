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
    public partial class InstructorDB : Form
    {
        
        public InstructorDB(int ID)
        {
            InitializeComponent();
            IDLbl.Text = ID.ToString();
        }
    }
}
