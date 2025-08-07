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
    public partial class ViewVehicles : Form
    {
        public ViewVehicles()
        {
            InitializeComponent();
        }

        private void ViewVehicles_Load(object sender, EventArgs e)
        {
            vehicleMJTableAdapter1.Fill(managerDataSet1.VehicleMJ);
        }

        private void searchvehiclesbox_TextChanged(object sender, EventArgs e)
        {
            vehicleMJTableAdapter1.FillByVehicleType(managerDataSet1.VehicleMJ, searchvehiclesbox.Text);
        }
    }
}
