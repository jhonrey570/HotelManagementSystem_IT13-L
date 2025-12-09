using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void lblHotelName_Click(object sender, EventArgs e)
        {

        }

        //Custom Add
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy hh:mm tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTodaySummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
