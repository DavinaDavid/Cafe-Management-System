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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True");
            SqlDataAdapter sqa = new SqlDataAdapter("select Password from CashierLogin1 where Password='" + currpass.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows.Count.ToString() == "1")
            {
                if (newpass.Text == confpass.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText=("Update CashierLogin1 set Password='" + newpass.Text + "' where Password='" +currpass.Text + "'");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText=("Update NewCashier set Password='" + newpass.Text + "' where Password='" + currpass.Text + "'");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label5.Visible = true;
                    label5.Text = "Successfully Updated";
                }

                else
                {
                    label5.Visible = true;
                    label5.ForeColor = Color.Red;
                    label5.Text = "new and confirm password should be same";
                   
                }
            }
            else
            {
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "please check your current password";
                

            }


        }

        private void bck_Click(object sender, EventArgs e)
        {
            loginform f = new loginform();
            f.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                currpass.UseSystemPasswordChar = true;
                newpass.UseSystemPasswordChar = true;
                confpass.UseSystemPasswordChar = true;
            }
            else
            {
                currpass.UseSystemPasswordChar = false;
                newpass.UseSystemPasswordChar = false;
                confpass.UseSystemPasswordChar = false;
            }

        }

        private void update_texts(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if(c.Text=="")
            {
                errorProvider1.SetError(c,"Empty Field");
                c.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
