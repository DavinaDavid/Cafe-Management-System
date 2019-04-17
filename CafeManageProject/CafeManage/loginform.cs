using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vplproject1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "" && passtxt.Text == "") { MessageBox.Show("Fields are empty"); }
            else
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adpt = new SqlDataAdapter();
                DataTable ds;
                adpt = new SqlDataAdapter("SELECT * FROM CashierLogin1 where Username='" + usertxt.Text + "' and Password='" + passtxt.Text + "'", "Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True");
                ds = new DataTable();
                adpt.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    if (usertxt.Text=="admin" && passtxt.Text=="admin")
                    {
                        adminpanel ad = new adminpanel();
                        ad.Show();
                        this.Hide();
                       
                        
                    }
                    else
                    {
                        Menu m = new Menu();
                        m.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("login failed");

                }
            }



           
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passtxt.UseSystemPasswordChar = true;
            }
            else
            {
                passtxt.UseSystemPasswordChar = false;
            }

            
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            Control c=(Control)sender;
            if(c.Text=="")
            {
               
                errorProvider1.SetError(c, "Please Enter the value");
                c.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateForm f = new UpdateForm();
            f.Show();
            this.Hide();
        }
    }
}
