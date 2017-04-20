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
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new TruckAppEntities1();

            var loadClientQ = db.Clients;
            List < Client > clList = loadClientQ.ToList();
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
        }
    }
}
