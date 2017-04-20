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
            //Int32 selectedval = (Int32)cbxClientID.SelectedValue;
           
                Staff obj = new Staff();
                obj.firstname = txtFirstname.Text;
                obj.lastname = txtLastname.Text;
                obj.id_number = txtID.Text;
                obj.cellphone_number = txtCellphone.Text;
                obj.street_number = Convert.ToInt32(txtStreetNumber.Text);
                obj.street_name = txtStreetName.Text;
                obj.street_area = txtAddressSuburb.Text;
                obj.address_city = txtCityAddress.Text;
                obj.address_province = txtAddressProvince.Text;
                
                db.Staffs.Add(obj);
                db.SaveChanges();

                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtID.Text = "";
                txtCellphone.Text = "";
                txtStreetNumber.Text = "";
                txtStreetName.Text = "";
                txtCityAddress.Text = "";
                txtAddressProvince.Text = "";
                

                var loadStaffQ = db.Staffs;
                List<Client> staffList = loadStaffQ.ToList();
                dgvStaffAll.DataSource = staffList;
                MessageBox.Show("Successfully Added");

            
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

        private void cbxClientID_TabIndexChanged(object sender, EventArgs e)
        {
           

            
        }

        private void cbxClientID_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxClientID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbxClientID_MouseDown(object sender, MouseEventArgs e)
        {
            
           
        }

        private void cbxClientID_TextUpdate(object sender, EventArgs e)
        {
            
            Int32 selectedVal = (Int32)cbxClientID.SelectedValue;
            if (selectedVal == -1)
            {
                //Make rest of things empty for add
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                txtLandline.Text = "";
                txtBusinessName.Text = "";
            }
            else
            {
                var pop2 = db.Clients.SingleOrDefault(i => i.client_id == selectedVal);
                txtBusinessName.Text = pop2.business_name;
                txtLandline.Text = pop2.client_landline;
                textBox1.Text = pop2.client_cellphone;
                textBox2.Text = pop2.client_lastname;
                textBox3.Text = pop2.client_firstname;
                textBox4.Text = pop2.client_address_areacode;
                textBox5.Text = pop2.client_city;
                textBox6.Text = pop2.client_address_area;
                textBox7.Text = pop2.client_address_number;
                textBox8.Text = pop2.client_address_street;
            }
        }

        private void cbxClientID_SelectedValueChanged(object sender, EventArgs e)
        {
            Int32 selectedVal = (Int32)cbxClientID.SelectedValue;
            if (selectedVal == -1)
            {
                //Make rest of things empty for add
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                txtLandline.Text = "";
                txtBusinessName.Text = "";
            }
            else
            {
                var pop2 = db.Clients.SingleOrDefault(i => i.client_id == selectedVal);
                txtBusinessName.Text = pop2.business_name;
                txtLandline.Text = pop2.client_landline;
                textBox1.Text = pop2.client_cellphone;
                textBox2.Text = pop2.client_lastname;
                textBox3.Text = pop2.client_firstname;
                textBox4.Text = pop2.client_address_areacode;
                textBox5.Text = pop2.client_city;
                textBox6.Text = pop2.client_address_area;
                textBox7.Text = pop2.client_address_number;
                textBox8.Text = pop2.client_address_street;
            }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Int32 selectedval = (Int32)cbxClientID.SelectedValue;
            if (selectedval != -1)
            {
                MessageBox.Show("Please select -1 to add");

            }
            else
            {
                try
                {
                    Client obj = new Client();
                    obj.business_name = txtBusinessName.Text;
                    obj.client_landline = txtLandline.Text;
                    obj.client_cellphone = textBox1.Text;
                    obj.client_lastname = textBox2.Text;
                    obj.client_firstname = textBox3.Text;
                    obj.client_address_areacode = textBox4.Text;
                    obj.client_city = textBox5.Text;
                    obj.client_address_area = textBox6.Text;
                    obj.client_address_number = textBox7.Text;
                    obj.client_address_street = textBox8.Text;
                    db.Clients.Add(obj);
                    db.SaveChanges();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    txtLandline.Text = "";
                    txtBusinessName.Text = "";

                    updateList();
                    MessageBox.Show("Successfully Added");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                var x = db.Clients.SingleOrDefault(i => i.client_id == (Int32)cbxClientID.SelectedValue);


                x.business_name = txtBusinessName.Text;
                x.client_landline = txtLandline.Text;
                x.client_cellphone = textBox1.Text;
                x.client_lastname = textBox2.Text;
                x.client_firstname = textBox3.Text;
                x.client_address_areacode = textBox4.Text;
                x.client_city = textBox5.Text;
                x.client_address_area = textBox6.Text;
                x.client_address_number = textBox7.Text;
                x.client_address_street = textBox8.Text;
                db.SaveChanges();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                txtLandline.Text = "";
                txtBusinessName.Text = "";

                updateList();
                MessageBox.Show("Successfully Updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                var x = db.Clients.FirstOrDefault(i => i.client_id == (Int32)cbxClientID.SelectedValue);
                db.Clients.Remove(x);
                db.SaveChanges();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                txtLandline.Text = "";
                txtBusinessName.Text = "";


                updateList();
                MessageBox.Show("Successfully Deleted");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Truck obj = new Truck();
            obj.mode_type = txtType.Text;
            obj.truck_type = txtMake.Text;
            obj.truck_weight = Convert.ToInt32(txtLFW.Text);
            obj.truck_kilos = Convert.ToInt32(txtTotKilo.Text);
            obj.fuel_usage_kilo = Convert.ToInt32(txtFU100.Text);
            obj.truck_capacity = Convert.ToInt32(txtLC.Text);
            obj.body_type_trailer = txtBT.Text;
            obj.horse_power = txtHP.Text;
            obj.fuel_tank_litre = Convert.ToInt32(txtTS.Text);

            db.Trucks.Add(obj);
            db.SaveChanges();

            txtType.Text = "";
            txtMake.Text = "";
            txtTotKilo.Text = "";
            txtLC.Text = "";
            txtLFW.Text = "";
            txtTS.Text = "";
            txtHP.Text = "";
            txtBT.Text = "";
            txtFU100.Text = "";
 
            var loadTrucks = db.Trucks;
            List<Truck> truckList = loadTrucks.ToList();
            dgvFleet.DataSource = truckList;
            MessageBox.Show("Successfully Added");
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

        private void updateList()
        {
            var popID = db.Clients;

            List<Int32> pop = new List<Int32>();
            pop.Add(-1);
            foreach (var data in popID)
            {
                pop.Add(data.client_id);
            }

            cbxClientID.DataSource = pop;

            var loadClientQ = db.Clients;
            List<Client> clList = loadClientQ.ToList();
            dgvClientList.DataSource = clList;
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

            updateList();

        }
    }
}
