namespace LinqDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientMan = new System.Windows.Forms.TabPage();
            this.lstbxDelete = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbxCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxAddress_Number = new System.Windows.Forms.TextBox();
            this.txtbxMail = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxAddress_AreaCode = new System.Windows.Forms.TextBox();
            this.txtbxAddress_Street = new System.Windows.Forms.TextBox();
            this.txtbxAddress_Area = new System.Windows.Forms.TextBox();
            this.txtbxCNum = new System.Windows.Forms.TextBox();
            this.txtbxLNum = new System.Windows.Forms.TextBox();
            this.txtbxBname = new System.Windows.Forms.TextBox();
            this.txtbxSname = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.staffMan = new System.Windows.Forms.TabPage();
            this.truckMan = new System.Windows.Forms.TabPage();
            this.goodsMan = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.clientMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientMan);
            this.tabControl1.Controls.Add(this.staffMan);
            this.tabControl1.Controls.Add(this.truckMan);
            this.tabControl1.Controls.Add(this.goodsMan);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1325, 483);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // clientMan
            // 
            this.clientMan.Controls.Add(this.lstbxDelete);
            this.clientMan.Controls.Add(this.btnDelete);
            this.clientMan.Controls.Add(this.label16);
            this.clientMan.Controls.Add(this.btnAddClient);
            this.clientMan.Controls.Add(this.label15);
            this.clientMan.Controls.Add(this.label14);
            this.clientMan.Controls.Add(this.label13);
            this.clientMan.Controls.Add(this.txtbxCity);
            this.clientMan.Controls.Add(this.label12);
            this.clientMan.Controls.Add(this.label11);
            this.clientMan.Controls.Add(this.label10);
            this.clientMan.Controls.Add(this.label9);
            this.clientMan.Controls.Add(this.label8);
            this.clientMan.Controls.Add(this.label7);
            this.clientMan.Controls.Add(this.label6);
            this.clientMan.Controls.Add(this.label5);
            this.clientMan.Controls.Add(this.label4);
            this.clientMan.Controls.Add(this.label3);
            this.clientMan.Controls.Add(this.txtbxAddress_Number);
            this.clientMan.Controls.Add(this.txtbxMail);
            this.clientMan.Controls.Add(this.txtbxPassword);
            this.clientMan.Controls.Add(this.txtbxUsername);
            this.clientMan.Controls.Add(this.txtbxAddress_AreaCode);
            this.clientMan.Controls.Add(this.txtbxAddress_Street);
            this.clientMan.Controls.Add(this.txtbxAddress_Area);
            this.clientMan.Controls.Add(this.txtbxCNum);
            this.clientMan.Controls.Add(this.txtbxLNum);
            this.clientMan.Controls.Add(this.txtbxBname);
            this.clientMan.Controls.Add(this.txtbxSname);
            this.clientMan.Controls.Add(this.txtbxName);
            this.clientMan.Controls.Add(this.label2);
            this.clientMan.Controls.Add(this.label1);
            this.clientMan.Controls.Add(this.dgvClientList);
            this.clientMan.Location = new System.Drawing.Point(4, 22);
            this.clientMan.Name = "clientMan";
            this.clientMan.Padding = new System.Windows.Forms.Padding(3);
            this.clientMan.Size = new System.Drawing.Size(1317, 457);
            this.clientMan.TabIndex = 0;
            this.clientMan.Text = "Client Management";
            this.clientMan.UseVisualStyleBackColor = true;
            // 
            // lstbxDelete
            // 
            this.lstbxDelete.FormattingEnabled = true;
            this.lstbxDelete.Location = new System.Drawing.Point(907, 229);
            this.lstbxDelete.Name = "lstbxDelete";
            this.lstbxDelete.Size = new System.Drawing.Size(401, 173);
            this.lstbxDelete.TabIndex = 38;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(907, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(401, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete Client";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1070, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Delete Client";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(10, 420);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(457, 23);
            this.btnAddClient.TabIndex = 34;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Username";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Email Address";
            // 
            // txtbxCity
            // 
            this.txtbxCity.Location = new System.Drawing.Point(248, 376);
            this.txtbxCity.Name = "txtbxCity";
            this.txtbxCity.Size = new System.Drawing.Size(100, 20);
            this.txtbxCity.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Address Area";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Address Streetnumber";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Address Street Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Address Areacode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Business Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "LandLine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cellphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "First Name";
            // 
            // txtbxAddress_Number
            // 
            this.txtbxAddress_Number.Location = new System.Drawing.Point(248, 296);
            this.txtbxAddress_Number.Name = "txtbxAddress_Number";
            this.txtbxAddress_Number.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddress_Number.TabIndex = 19;
            // 
            // txtbxMail
            // 
            this.txtbxMail.Location = new System.Drawing.Point(367, 338);
            this.txtbxMail.Name = "txtbxMail";
            this.txtbxMail.Size = new System.Drawing.Size(100, 20);
            this.txtbxMail.TabIndex = 18;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(367, 295);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxPassword.TabIndex = 17;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(367, 250);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtbxUsername.TabIndex = 14;
            // 
            // txtbxAddress_AreaCode
            // 
            this.txtbxAddress_AreaCode.Location = new System.Drawing.Point(248, 338);
            this.txtbxAddress_AreaCode.Name = "txtbxAddress_AreaCode";
            this.txtbxAddress_AreaCode.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddress_AreaCode.TabIndex = 10;
            // 
            // txtbxAddress_Street
            // 
            this.txtbxAddress_Street.Location = new System.Drawing.Point(248, 250);
            this.txtbxAddress_Street.Name = "txtbxAddress_Street";
            this.txtbxAddress_Street.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddress_Street.TabIndex = 9;
            // 
            // txtbxAddress_Area
            // 
            this.txtbxAddress_Area.Location = new System.Drawing.Point(129, 338);
            this.txtbxAddress_Area.Name = "txtbxAddress_Area";
            this.txtbxAddress_Area.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddress_Area.TabIndex = 8;
            // 
            // txtbxCNum
            // 
            this.txtbxCNum.Location = new System.Drawing.Point(129, 296);
            this.txtbxCNum.Name = "txtbxCNum";
            this.txtbxCNum.Size = new System.Drawing.Size(100, 20);
            this.txtbxCNum.TabIndex = 7;
            // 
            // txtbxLNum
            // 
            this.txtbxLNum.Location = new System.Drawing.Point(129, 250);
            this.txtbxLNum.Name = "txtbxLNum";
            this.txtbxLNum.Size = new System.Drawing.Size(100, 20);
            this.txtbxLNum.TabIndex = 6;
            // 
            // txtbxBname
            // 
            this.txtbxBname.Location = new System.Drawing.Point(10, 338);
            this.txtbxBname.Name = "txtbxBname";
            this.txtbxBname.Size = new System.Drawing.Size(100, 20);
            this.txtbxBname.TabIndex = 5;
            // 
            // txtbxSname
            // 
            this.txtbxSname.Location = new System.Drawing.Point(10, 296);
            this.txtbxSname.Name = "txtbxSname";
            this.txtbxSname.Size = new System.Drawing.Size(100, 20);
            this.txtbxSname.TabIndex = 4;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(10, 250);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 20);
            this.txtbxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvClientList
            // 
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Location = new System.Drawing.Point(6, 21);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.Size = new System.Drawing.Size(1302, 176);
            this.dgvClientList.TabIndex = 0;
            this.dgvClientList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientList_CellEndEdit);
            // 
            // staffMan
            // 
            this.staffMan.Location = new System.Drawing.Point(4, 22);
            this.staffMan.Name = "staffMan";
            this.staffMan.Padding = new System.Windows.Forms.Padding(3);
            this.staffMan.Size = new System.Drawing.Size(1317, 457);
            this.staffMan.TabIndex = 1;
            this.staffMan.Text = "Staff Management";
            this.staffMan.UseVisualStyleBackColor = true;
            // 
            // truckMan
            // 
            this.truckMan.Location = new System.Drawing.Point(4, 22);
            this.truckMan.Name = "truckMan";
            this.truckMan.Size = new System.Drawing.Size(1317, 457);
            this.truckMan.TabIndex = 2;
            this.truckMan.Text = "Truck Management";
            this.truckMan.UseVisualStyleBackColor = true;
            // 
            // goodsMan
            // 
            this.goodsMan.Location = new System.Drawing.Point(4, 22);
            this.goodsMan.Name = "goodsMan";
            this.goodsMan.Size = new System.Drawing.Size(1317, 457);
            this.goodsMan.TabIndex = 3;
            this.goodsMan.Text = "Goods Management";
            this.goodsMan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 477);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Truck System Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.clientMan.ResumeLayout(false);
            this.clientMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientMan;
        private System.Windows.Forms.TabPage staffMan;
        private System.Windows.Forms.TabPage truckMan;
        private System.Windows.Forms.TabPage goodsMan;
        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbxCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxAddress_Number;
        private System.Windows.Forms.TextBox txtbxMail;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxAddress_AreaCode;
        private System.Windows.Forms.TextBox txtbxAddress_Street;
        private System.Windows.Forms.TextBox txtbxAddress_Area;
        private System.Windows.Forms.TextBox txtbxCNum;
        private System.Windows.Forms.TextBox txtbxLNum;
        private System.Windows.Forms.TextBox txtbxBname;
        private System.Windows.Forms.TextBox txtbxSname;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.ListBox lstbxDelete;
    }
}

