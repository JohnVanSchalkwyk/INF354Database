using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            FleetManagement fm = new FleetManagement();
            fm.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffManagement sm = new StaffManagement();
            sm.ShowDialog();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Bookings b = new Bookings();
            b.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientManagement cm = new ClientManagement();
            cm.ShowDialog();
        }
    }
}
