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
            this.staffMan = new System.Windows.Forms.TabPage();
            this.truckMan = new System.Windows.Forms.TabPage();
            this.goodsMan = new System.Windows.Forms.TabPage();
            this.dgvClientList = new System.Windows.Forms.DataGridView();
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
            this.clientMan.Controls.Add(this.dgvClientList);
            this.clientMan.Location = new System.Drawing.Point(4, 22);
            this.clientMan.Name = "clientMan";
            this.clientMan.Padding = new System.Windows.Forms.Padding(3);
            this.clientMan.Size = new System.Drawing.Size(1317, 457);
            this.clientMan.TabIndex = 0;
            this.clientMan.Text = "Client Management";
            this.clientMan.UseVisualStyleBackColor = true;
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
            // dgvClientList
            // 
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Location = new System.Drawing.Point(24, 27);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.Size = new System.Drawing.Size(1272, 176);
            this.dgvClientList.TabIndex = 0;
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
    }
}

