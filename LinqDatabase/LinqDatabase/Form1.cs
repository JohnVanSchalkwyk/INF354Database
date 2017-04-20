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
        TruckAppEntities1 db = new TruckAppEntities1();
        bool addStaffTab = false, addClientTab = false, addFleetTab =false;
        List<Client> clList;
        List<Staff> slList;




        public Form1()
        {
            InitializeComponent();
            tbAddStaff.Hide();
            tbAddClient.Hide();
            tbVehicle.Hide();
            addStaffTab = false;
            addClientTab = false;
            addFleetTab = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            var loadClientQ = db.Clients;
            var loadStaffQ = db.Staffs;
            var loadGoods = db.BookingGoods;
            var loadFleet = db.Trucks;


            List<Client> clList = loadClientQ.ToList();
            List<Staff> slList = loadStaffQ.ToList();
            List<Truck> fleet = loadFleet.ToList();
            List<BookingGood> goods = loadGoods.ToList();


            //=================================================================
            //          Populate the DataGridViews
            //=================================================================
            dgvClientList.DataSource = clList;
            dgvStaffAll.DataSource = slList;
            dgvFleet.DataSource = fleet;
            dgvGoods.DataSource = goods;

            //=================================================================
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (addStaffTab == true)
            {
                tbAddStaff.Hide();
                addStaffTab = false;
            }
            else
            {
                tbAddStaff.Show();
                addStaffTab = true;
            }            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Staff> slList;
        }

        private void clientMan_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (addFleetTab == true)
            {
                tbVehicle.Hide();
                addFleetTab = false;
            }
            else
            {
                tbVehicle.Show();
                addFleetTab = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (addClientTab == true)
            {
                tbAddClient.Hide();
                addClientTab = false;
            }
            else
            {
                tbAddClient.Show();
                addClientTab = true;
            }

        }
    }
}
