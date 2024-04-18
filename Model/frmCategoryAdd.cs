using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeeling_Ka.Model
{
    public partial class frmCategoryAdd : SampleAdd 
    {
        private Timer buttonTimer = new Timer();
        public frmCategoryAdd()
        {
            InitializeComponent();
            buttonTimer.Tick += new EventHandler(buttonTimer_Tick);
            buttonTimer.Interval = 500;
        }

        public int id = 0;

        private void frmCategoryAdd_Shown(object sender, EventArgs e)
        {
            buttonTimer.Start();
        }

        void buttonTimer_Tick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            buttonTimer.Stop();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //return this
            string qry = "";

            if (id == 0)
            {
                qry = "insert into category values (@Name)";
            }
            else
            {
                qry = "update category set catName = @Name where catID = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully...");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && (e.Handled = !char.IsControl(e.KeyChar)) && (e.Handled = char.IsPunctuation(e.KeyChar)) ;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click_1(this, new EventArgs());
            }
        }
    }
}
