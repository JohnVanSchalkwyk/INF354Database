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
        bool addStaffTab = false, addClientTab = false, addFleetTab = false, addGoods = false;



        public Form1()
        {
            InitializeComponent();
            tbAddStaff.Hide();
            tbAddClient.Hide();
            tbVehicle.Hide();
            addStaffTab = false;
            addClientTab = false;
            addFleetTab = false;
            addGoods = false;
            tabControlGoods.Hide();
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


            List<Client> clList = loadClientQ.OrderBy(a => a.client_firstname).ToList();
            List<Staff> slList = loadStaffQ.OrderBy(a => a.staff_id).ToList();
            List<Truck> fleet = loadFleet.OrderBy(a => a.body_type_trailer).ToList();
            List<BookingGood> goods = loadGoods.ToList();


            //=================================================================
            //          Populate the DataGridViews
            //=================================================================
            dgvClientList.DataSource = clList;
            dgvStaffAll.DataSource = slList;
            dgvFleet.DataSource = fleet;
            dgvGoods.DataSource = goods;

            //=================================================================

            var loadDepart = db.StaffDepartments;
            List<StaffDepartment> dpt = loadDepart.ToList();

            List<Int32> pop = new List<Int32>();
            foreach (var data in dpt)
            {
                pop.Add(data.department_id);
            }

            cbxDepartment.DataSource = pop;

            var licType = db.DriversLiscenceCodes;
            List<DriversLiscenceCode> cd = licType.ToList();

            List<String> lis = new List<string>();
            foreach(var data2 in cd)
            {
                lis.Add(data2.code_type);
            }
            cbxLicenseType.DataSource = lis;
            cbxLicenseTruck.DataSource = lis;


            var sleepType = db.TruckSleepTypes;
            List<TruckSleepType> tp = sleepType.ToList();

            List<String> TP = new List<string>();
            foreach (var data2 in tp)
            {
                TP.Add(data2.type_name);
            }
            cbxSleepType.DataSource = TP;


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
            //Check if all fields are filled
            if (txtFirstname.Text == "" || txtLastname.Text == "" || txtID.Text == "" || txtCellphone.Text == "" || txtStreetName.Text == "" || txtStreetNumber.Text == "" || txtAddressSuburb.Text == "" || txtCityAddress.Text == "" || txtAddressSuburb.Text == "" || txtbxBankNum.Text == "" || txtbxBankName.Text == "" || txtbxBankType.Text == "" || txtbxBranchCode.Text == "" || txtbxBranchName.Text == "" || txtbxPassword.Text == "" || txtbxUsername.Text == "")
            {
                MessageBox.Show("Please fill in all required fields");
            }
            else
            {
           
                    //First we create a new banking profile
                    StaffBankingDetail obj1 = new StaffBankingDetail();
                    obj1.account_number = txtbxBankNum.Text;
                    obj1.account_type = txtbxBankType.Text;
                    obj1.bank_name = txtbxBankName.Text;
                    obj1.branch_code = txtbxBranchCode.Text;
                    obj1.branch_name = txtbxBranchName.Text;
                    db.StaffBankingDetails.Add(obj1);
                    db.SaveChanges();

                    var bid = obj1.banking_id;
                    var lic = db.DriversLiscenceCodes.SingleOrDefault(a => a.code_type == cbxLicenseType.SelectedValue.ToString());

                //Create A Login Profile
                StaffLogin obj2 = new StaffLogin();
                obj2.password = txtbxPassword.Text;
                obj2.username = txtbxUsername.Text;
                db.StaffLogins.Add(obj2);
                db.SaveChanges();

                var loginID = obj2.login_id;
              

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
                    obj.banking_id = bid;
                    obj.department_id = (Int32)cbxDepartment.SelectedValue;
                    obj.licence_code_id = lic.licence_code_id;
                obj.login_id = loginID;

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
                    txtbxBankName.Text = "";
                    txtbxBankNum.Text = "";
                    txtbxBankType.Text = "";
                    txtbxBranchCode.Text = "";
                    txtbxBranchName.Text = "";
                txtAddressSuburb.Text = "";
                txtbxUsername.Text = "";
                txtbxPassword.Text = "";


                    updateList();
                    MessageBox.Show("Successfully Added");
                

            }

            
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
            if (txtbxRegistration.Text == "" || txtbxRegistration.Text == "" || txtType.Text == "" || txtMake.Text == "" || txtTotKilo.Text == "" || txtLC.Text == "" || txtLFW.Text == "" || txtTS.Text == "" || txtHP.Text == "" || txtBT.Text == "" || txtFU100.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                try
                {
                    //Create new Maintenance Object
                    TruckMaintenance obj1 = new TruckMaintenance();
                    obj1.kilos_serviced = Convert.ToInt32(txtbxKiloLastServiced.Text);
                    obj1.date_last_service = dtpLastService.Value;
                    obj1.date_tires_renewed = dtpLastTyre.Value;
                    db.TruckMaintenances.Add(obj1);
                    db.SaveChanges();

                    var id = obj1.maintenance_id;

                    //Get License ID
                    var licID = db.DriversLiscenceCodes.SingleOrDefault(a => a.code_type == cbxLicenseTruck.SelectedValue.ToString());


                    //Get Sleeper ID
                    var sleepid = db.TruckSleepTypes.SingleOrDefault(a => a.type_name == cbxSleepType.SelectedValue.ToString());

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
                    obj.maintenance_id = id;
                    obj.sleeping_type_id = sleepid.sleeping_type_id;
                    obj.licence_code_id = licID.licence_code_id;
                    obj.truck_registration = txtbxRegistration.Text;

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
                    txtbxRegistration.Text = "";
                    txtbxKiloLastServiced.Text = "";


                    var loadTrucks = db.Trucks;
                    List<Truck> truckList = loadTrucks.ToList();
                    dgvFleet.DataSource = truckList;
                    MessageBox.Show("Successfully Added");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
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

        private void cbxGoodsID_TextUpdate(object sender, EventArgs e)
        {
            Int32 selectedVal = (Int32)cbxGoodsID.SelectedValue;
            if (selectedVal == -1)
            {
                //Make rest of things empty for add
                rtxtDescriptGoods.Text = "";
                txtbxGoodName.Text = "";
            }
            else
            {
                var pop2 = db.BookingGoods.SingleOrDefault(i =>  i.goods_id == selectedVal);
                rtxtDescriptGoods.Text = pop2.goods_description;
                txtbxGoodName.Text = pop2.goods_type;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Int32 selectedval = (Int32)cbxGoodsID.SelectedValue;
            if (selectedval != -1)
            {
                MessageBox.Show("Please select -1 to add");

            }
            else
            {
                try
                {
                    BookingGood obj = new BookingGood();
                    obj.goods_type = txtbxGoodName.Text;
                    obj.goods_description = rtxtDescriptGoods.Text;
                    db.BookingGoods.Add(obj);
                    db.SaveChanges();

                    txtbxGoodName.Text = "";
                    rtxtDescriptGoods.Text = "";
                    updateList();
                    MessageBox.Show("Successfully Added Good");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var x = db.BookingGoods.FirstOrDefault(i => i.goods_id == (Int32)cbxGoodsID.SelectedValue);
                db.BookingGoods.Remove(x);
                db.SaveChanges();

                txtbxGoodName.Text = "";
                rtxtDescriptGoods.Text = "";


                updateList();
                MessageBox.Show("Successfully Deleted Good");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                var x = db.BookingGoods.FirstOrDefault(i => i.goods_id == (Int32)cbxGoodsID.SelectedValue);



                x.goods_type = txtbxGoodName.Text;
                x.goods_description = rtxtDescriptGoods.Text;
                db.SaveChanges();

                txtbxGoodName.Text = "";
                rtxtDescriptGoods.Text = "";

                updateList();
                MessageBox.Show("Successfully Updated Good");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cbxGoodsID_DisplayMemberChanged(object sender, EventArgs e)
        {
            Int32 selectedVal = (Int32)cbxGoodsID.SelectedValue;
            if (selectedVal == -1)
            {
                //Make rest of things empty for add
                rtxtDescriptGoods.Text = "";
                txtbxGoodName.Text = "";
            }
            else
            {
                var pop2 = db.BookingGoods.SingleOrDefault(i => i.goods_id == selectedVal);
                rtxtDescriptGoods.Text = pop2.goods_description;
                txtbxGoodName.Text = pop2.goods_type;
            }
        }

        private void cbxGoodsID_SelectedValueChanged(object sender, EventArgs e)
        {
            Int32 selectedVal = (Int32)cbxGoodsID.SelectedValue;
            if (selectedVal == -1)
            {
                //Make rest of things empty for add
                rtxtDescriptGoods.Text = "";
                txtbxGoodName.Text = "";
            }
            else
            {
                var pop2 = db.BookingGoods.SingleOrDefault(i => i.goods_id == selectedVal);
                rtxtDescriptGoods.Text = pop2.goods_description;
                txtbxGoodName.Text = pop2.goods_type;
            }
        }

        private void truckMan_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void cbxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            Int32 selectedVal = (Int32)cbxDepartment.SelectedValue;
            
            var pop2 = db.StaffDepartments.SingleOrDefault(i => i.department_id == selectedVal);
            rtbxDepartName.Text = pop2.department_name;
            rtbxDepartDescrip.Text = pop2.department_description;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if(addGoods == true)
            {
                tabControlGoods.Hide();
                addGoods = false;
            }
            else
            {
                tabControlGoods.Show();
                addGoods = true;
            }

            updateList();
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

            var popGID = db.BookingGoods;

            List<Int32> popG = new List<Int32>();
            popG.Add(-1);

            foreach(var data in popGID)
            {
                popG.Add(data.goods_id);
            }

            cbxGoodsID.DataSource = popG;

            var loadClientQ = db.Clients;
            List<Client> clList = loadClientQ.OrderBy(a => a.client_firstname).ToList();
            dgvClientList.DataSource = clList;

            var loadBookQ = db.BookingGoods;
            List<BookingGood> blList = loadBookQ.ToList();
            dgvGoods.DataSource = blList;


           
            var loadStaffQ = db.Staffs;
            var loadFleet = db.Trucks;



            List<Staff> slList = loadStaffQ.ToList();
            List<Truck> fleet = loadFleet.OrderBy(a => a.truck_type).ToList();


            //=================================================================
            //          Populate the DataGridViews
            //=================================================================
            dgvStaffAll.DataSource = slList;
            dgvFleet.DataSource = fleet;

            //=================================================================


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
