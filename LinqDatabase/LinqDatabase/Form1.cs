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

        TruckAppEntities1 db;

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

            db = new TruckAppEntities1();


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


            var load = db.Clients;

            int i = 0;
            foreach(var data in load)
            {
                Item adder = new Item();
                adder.Text = data.client_firstname + " " + data.client_lastname;
                adder.Value = (Int32)data.client_id;
                lstbxDelete.Items.Insert(i,adder);
                i++;
            }

            dgvStaffAll.DataSource = slList;
            dgvFleet.DataSource = fleet;
            dgvGoods.DataSource = goods;

            //=================================================================

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dgvClientList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var save = (List<Client>)dgvClientList.DataSource;
            db.SaveChanges();
            dgvClientList.Refresh();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Item it = (Item)lstbxDelete.SelectedItem;

                
                var xy = db.ClientLogins.SingleOrDefault(i => i.clientLogin_id == it.Value);
                db.ClientLogins.Remove(xy);
                db.SaveChanges();
                var x = db.Clients.SingleOrDefault(i => i.client_id == it.Value);
                db.Clients.Remove(x);
                db.SaveChanges();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                this.Refresh();
            }

                       
            

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientLogin log = new ClientLogin();
            log.clientUser = txtbxUsername.Text;
            log.clientPass = txtbxPassword.Text;
            log.clientMail = txtbxMail.Text;

            db.ClientLogins.Add(log);
            db.SaveChanges();

            
            Client newC = new Client();

            newC.client_firstname = txtbxName.Text;
            newC.client_lastname = txtbxSname.Text;
            newC.client_landline = txtbxLNum.Text;
            newC.client_cellphone = txtbxCNum.Text;
            newC.client_address_area = txtbxAddress_Area.Text;
            newC.client_address_areacode = txtbxAddress_AreaCode.Text;
            newC.client_address_number = txtbxAddress_Number.Text;
            newC.client_address_street = txtbxAddress_Street.Text;
            newC.business_name = txtbxBname.Text;
            newC.client_city = txtbxCity.Text;
            newC.client_login = log.clientLogin_id;

            db.Clients.Add(newC);
            db.SaveChanges();

            MessageBox.Show("Added Successfully");
        }
    }

    public class Item
    {
        public string Text;
        public Int32 Value;
        public override string ToString()
        {
            return this.Text;

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
