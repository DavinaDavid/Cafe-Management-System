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
    public partial class adminpanel : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter adap;
        DataSet ds;
        string connection = " Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True";
        void loaddataforCashier()
        {
            con = new SqlConnection(connection);
            adap = new SqlDataAdapter("Select * from NewCashier", con);
            ds = new DataSet();
            adap.Fill(ds,"NewCashier");
            CashierGrid.DataSource = ds.Tables["NewCashier"];
            dataGridView3.DataSource = ds.Tables["NewCashier"];
        }
        void loaddataforCoffee()
        {
            con = new SqlConnection(connection);
            ds = new DataSet();
            adap = new SqlDataAdapter("Select * from Items1 where Category='Coffee'", con);
            adap.Fill(ds, "Items1");
            dataGridView1.DataSource = ds.Tables["Items1"];
        }
        public void loadalldata()
        {
            con = new SqlConnection(connection);
            ds = new DataSet();
            adap = new SqlDataAdapter("Select * from Items1 ", con);
            adap.Fill(ds, "Items1");
            CoffeeGrid1.DataSource = ds.Tables["Items1"];
        }

        public void loaddataforstock()
        {
            con = new SqlConnection(connection);
            ds = new DataSet();
            adap = new SqlDataAdapter("Select * from Stock_Details ", con);
            adap.Fill(ds, "Stock_Details");
          dataGridView2.DataSource = ds.Tables["Stock_Details"];
        }
        void loaddataforTea()
        {
            con = new SqlConnection(connection);
            ds = new DataSet();
            adap = new SqlDataAdapter("Select * from Items1 where Category='Tea'", con);
            adap.Fill(ds, "Items1");
            dataGridView1.DataSource = ds.Tables["Items1"];
        }

        public adminpanel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void loadfromcake()
        {
            con = new SqlConnection(connection);
            ds = new DataSet();
            adap = new SqlDataAdapter("Select * from Items1 where Category='Cake'", con);
            adap.Fill(ds, "Items1");
            dataGridView1.DataSource = ds.Tables["Items1"];
        }
        private void adminpanel_Load(object sender, EventArgs e)
        {
            ManageStockPanel.Visible = true;
            stockpanel.Visible = false;
            AddStockPanel.Visible = false;
            cashierpanel.Visible = false;
            Salespanel.Visible = false;
            ManageCashierPanel.Visible = false;
        }

        private void addstock_btn(object sender, EventArgs e)
        {
            loadalldata();
            AddStockPanel.Visible = true;
            cashierpanel.Visible = false;
            Salespanel.Visible = false;
            ManageStockPanel.Visible = false;
            stockpanel.Visible = false;
            ManageCashierPanel.Visible = false;


        }

        private void AddStockPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addcashier_btn_Click(object sender, EventArgs e)
        {
            loaddataforCashier();
            cashierpanel.Visible = true;
            AddStockPanel.Visible = false;
            Salespanel.Visible = false;
            ManageStockPanel.Visible = false;
            stockpanel.Visible = false;
            ManageCashierPanel.Visible = false;
            
        }

        private void cakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CakeAddPanel.Visible = true;
            TeaAddPanel.Visible = false;
            //CoffeeAddPanel.Visible = false;
        }

        private void coffeeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
           // CoffeeAddPanel.Visible = true;
           // CakeAddPanel.Visible = false;
            TeaAddPanel.Visible = false;
        }

        private void teaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeaAddPanel.Visible = true;
           // CoffeeAddPanel.Visible = false;
            //CakeAddPanel.Visible = false;
            
        }
      

        private void AddCashier_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "Insert into NewCashier values('" + CashNameTxt.Text + "','" + CashPassTxt.Text + "','" + CashEmailTxt.Text + "','" + CashPhoneTxt.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into CashierLogin1 values('" + CashNameTxt.Text + "','" + CashPassTxt.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            loaddataforCashier();
            con.Close();
        }

      

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(category.SelectedIndex==0)
            {
                pictureBox3.Image = Properties.Resources.choc_drip_cake;
                AddItem.Text = "Add Cake";
                label2.Text= "Cake";
                loadfromcake();
            }
           if(category.SelectedIndex ==1)
            {
                pictureBox3.Image = Properties.Resources.tea;
                AddItem.Text = "Add Tea";
                label2.Text = "Tea";
                loaddataforTea();
                
            }
           if (category.SelectedIndex == 2)
            {
                pictureBox3.Image = Properties.Resources.coff;
                AddItem.Text = "Add Coffee";
                label2.Text = "Coffee";
                loaddataforTea();
            }

        }

        private void Additem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Items1 values('" + category.SelectedItem + "','" + coffname.Text + "','" + coffprice.Text + "')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            loadalldata();
            con.Close();

        }

        private void Sales_Record_btn(object sender, EventArgs e)
        {
            Salespanel.Visible = true;
            cashierpanel.Visible = false;
            AddStockPanel.Visible = false;
            ManageStockPanel.Visible = false;
            stockpanel.Visible = false;
            ManageCashierPanel.Visible = false;

            con = new SqlConnection(connection);
            ds = new DataSet();
            adap = new SqlDataAdapter("Select * from Sales", con);
            adap.Fill(ds, "Sales");
          SalesGrid.DataSource = ds.Tables["Sales"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StockManagecombo.SelectedIndex == 0)
                 {
                con = new SqlConnection(connection);
                ds = new DataSet();
                adap = new SqlDataAdapter("Select * from Items1 where Category='"+StockManagecombo.SelectedItem+"'", con);
                adap.Fill(ds, "Items1");
                dataGridView1.DataSource = ds.Tables["Items1"];
                }
            if (StockManagecombo.SelectedIndex == 1)
            {
                con = new SqlConnection(connection);
                ds = new DataSet();
                adap = new SqlDataAdapter("Select * from Items1 where Category='" + StockManagecombo.SelectedItem + "'", con);
                adap.Fill(ds, "Items1");
                dataGridView1.DataSource = ds.Tables["Items1"];
            }
            if (StockManagecombo.SelectedIndex == 2)
            {
                con = new SqlConnection(connection);
                ds = new DataSet();
                adap = new SqlDataAdapter("Select * from Items1 where Category='" + StockManagecombo.SelectedItem + "'", con);
                adap.Fill(ds, "Items1");
                dataGridView1.DataSource = ds.Tables["Items1"];
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageStock_Click(object sender, EventArgs e)
        {
           
            ManageStockPanel.Visible = true;
            Salespanel.Visible = false;
            cashierpanel.Visible = false;
            AddStockPanel.Visible = false;
            stockpanel.Visible = false;
            ManageCashierPanel.Visible = false;


        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (StockManagecombo.SelectedIndex == 0)
            {

                con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Delete from Items1 where(Item_id = '" + numericUpDown1.Text + "' and Category='"+StockManagecombo.SelectedItem+"' )";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                loadfromcake();
                con.Close();
            
                
            }
            if (StockManagecombo.SelectedIndex == 1)
            {
                con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Delete from Items1 where(Item_id = '" + numericUpDown1.Text + "' and Category='" + StockManagecombo.SelectedItem + "' )";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                loaddataforCoffee();
                con.Close();
            }
            if (StockManagecombo.SelectedIndex == 2)
            {
                con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Delete from Items1 where(Item_id = '" + numericUpDown1.Text + "' and Category='" + StockManagecombo.SelectedItem + "' )";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                loaddataforTea();
                con.Close();
            
           
            }
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            if (StockManagecombo.SelectedIndex == 0)
            {
                con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Items1 where Item_Id = '" + numericUpDown1.Text + "'";
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    itemTxt.Text = reader["Item_Name"].ToString();
                    // QuantTxt.Text = reader["teaQuant"].ToString();
                    PriceTxt.Text = reader["Price"].ToString();

                }
                //cmd.ExecuteNonQuery();
                con.Close();
            }
            if (StockManagecombo.SelectedIndex == 1)
            {
                con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Items1 where Item_Id = '" + numericUpDown1.Text + "'";
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    itemTxt.Text = reader["Item_Name"].ToString();
                    // QuantTxt.Text = reader["teaQuant"].ToString();
                    PriceTxt.Text = reader["Price"].ToString();

                }
                con.Close();
            }
            if (StockManagecombo.SelectedIndex == 2)
            {
                con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Items1 where Item_Id = '" + numericUpDown1.Text + "'";
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    itemTxt.Text = reader["Item_Name"].ToString();
                   // QuantTxt.Text = reader["teaQuant"].ToString();
                    PriceTxt.Text = reader["Price"].ToString();

                }
                //cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StockManagecombo.SelectedIndex == 0) { 
                con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Update Items1 set item_Name= '" + itemTxt.Text + "',Price= '" + PriceTxt.Text + "' where Item_Id = '" + numericUpDown1.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                loadfromcake();
                con.Close();
            }

            if (StockManagecombo.SelectedIndex == 1)
            {
                con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText ="Update Items1 set item_Name= '" + itemTxt.Text + "', Price= '" + PriceTxt.Text + "' where Item_Id = '" + numericUpDown1.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                loaddataforCoffee();
                con.Close();
            }
            if (StockManagecombo.SelectedIndex == 2)
            {
                con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText ="Update Items1 set item_Name= '" + itemTxt.Text + "',Price= '" + PriceTxt.Text + "' where Item_Id = '" + numericUpDown1.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                loaddataforTea();
                con.Close();
            }
        }

        private void Stock_Detailss_Click(object sender, EventArgs e)
        {
            loaddataforstock();
            stockpanel.Visible = true;
            cashierpanel.Visible = false;
            AddStockPanel.Visible = false;
            Salespanel.Visible = false;
            ManageStockPanel.Visible = false;


        }

        private void set_stock_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Stock_Id = '" + numericUpDown2.Text + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["Actual_Stock"].ToString();
            }
            con.Close();

        }

        private void update_stock_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Update Stock_Details set Actual_Stock= '" + textBox1.Text + "' where Stock_Id = '" + numericUpDown2.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            loaddataforstock();
            con.Close();
        }

        private void SetCashier_Click(object sender, EventArgs e)
        {

           
            con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from NewCashier where CID = '" + numericUpDown3.Text + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Name"].ToString();
                textBox3.Text = reader["Password"].ToString();
                textBox4.Text = reader["Email"].ToString();
                textBox5.Text = reader["Phone_No"].ToString();
            }
            loaddataforCashier();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loaddataforCashier();
            ManageCashierPanel.Visible = true;
            Salespanel.Visible = false;
            cashierpanel.Visible = false;
            AddStockPanel.Visible = false;
            ManageStockPanel.Visible = false;
            stockpanel.Visible = false;
        }

        private void updateCashier_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Update NewCashier set Name= '" + textBox2 + "',Password= '" + textBox3.Text + "',Email= '" + textBox4.Text + "' ,Phone_No= '" + textBox5.Text + "' where CID = '" + numericUpDown3.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Update CashierLogin1 set Username= '" + textBox2 + "',Password= '" + textBox3.Text + "'where Username = '" + textBox2.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            loaddataforCashier();
            con.Close();
        }

        private void DetleCashier_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete from NewCashier where CID = '" + numericUpDown3.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Delete from CashierLogin1 where Username = '" + textBox2.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            loaddataforCashier();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

