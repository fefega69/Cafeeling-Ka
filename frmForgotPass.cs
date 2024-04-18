using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeeling_Ka
{
    public partial class frmForgotPass : Form
    {
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmL = new frmLogin();

            frmL.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT username, upass FROM users WHERE username = @username AND masterkey = @masterkey", MainClass.con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@masterkey", txtMK.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["upass"].ToString();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Question Answer");
                textBox1.Text = "";
            }
            MainClass.con.Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
