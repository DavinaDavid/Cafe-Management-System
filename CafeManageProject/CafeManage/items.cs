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
using System.IO;

namespace vplproject1
{
    public partial class items : Form
    {
        int STOCK;
        int tea11, tea22, tea33, tea44, tea55, tea66=3;
        int stock11, stock22, stock33, stock44, stock55, stock66;
        static int totalammount = 0;
        int check_order_button_enter = 0;
        string constring = "Data Source=DESKTOP-S2LG294\\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True";
         static int idvalue=1;
        Menu m = new Menu();
        public void databaseinsert(int idval,string itemsname,decimal quantity,DateTime d,int total)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constring;
            SqlCommand com = new SqlCommand();
            com.CommandText = "Insert into OrderDetailsss values('" + idval + "','" + itemsname+ "','" + quantity+ "','" + d + "','" + total + "')";
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public items()
        {
            InitializeComponent();
            cakepanel.Visible = true;
            teapanel.Visible = false;
            coffeepanel.Visible = false;
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(billprint.Text,new Font("Time New Romans",20,FontStyle.Regular),Brushes.Black,new Point(0,0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

       private void forallorders_Click(object sender, EventArgs e)
        {
            billprint.Visible = false;
            if (check_order_button_enter == 0)
            {
                billprint.Text += "\t================================= ";
                billprint.Text += "\n            \t \t              ROYAL CAFE  ";
                billprint.Text += "\n\t================================= \n";
                check_order_button_enter++;
            }

           
            if (Coffee1.Checked == true)
            {
                var b = calculate(coffeeprice1.Text, Convert.ToInt32(coffquan1.Value));
                totalammount += b;
                billprint.Text += " " + Coffee1.Text + "       " + "          " + coffquan1.Value + "           " + b + "\n";
                //stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, Coffee1.Text, coffquan1.Value, DateTime.Now.Date, b);
                coffquan1.Value = 0;
                Coffee1.Checked = false;
                //stock checking//
 
            }
            if (Coffee2.Checked == true)
            {
                var b = calculate(coffeeprice2.Text, Convert.ToInt32(coffquan2.Value));
                totalammount += b;
                billprint.Text += " " + Coffee2.Text + "       " + "          " + coffquan2.Value + "           " + b + "\n";
                //stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, Coffee2.Text, coffquan2.Value, DateTime.Now.Date, b);
                coffquan2.Value = 0;
                Coffee2.Checked = false;
            }
            if (Coffee3.Checked == true)
            {
                var b = calculate(coffeeprice3.Text, Convert.ToInt32(coffquan3.Value));
                totalammount += b;
                billprint.Text += " " + Coffee3.Text + "       " + "          " + coffquan3.Value + "           " + b + "\n";
                //stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, Coffee3.Text, coffquan3.Value, DateTime.Now.Date, b);
                coffquan3.Value = 0;
                Coffee3.Checked = false;
            }
            if (Coffee4.Checked == true)
            {
                var b = calculate(coffeeprice4.Text, Convert.ToInt32(coffquan4.Value));
                totalammount += b;
                billprint.Text += " " + Coffee4.Text + "       " + "          " + coffquan4.Value + "           " + b + "\n";
                //stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, Coffee4.Text, coffquan4.Value, DateTime.Now.Date, b);
                coffquan4.Value = 0;
                Coffee4.Checked = false;
            }
            if (Coffee5.Checked == true)
            {
                var b = calculate(coffeeprice5.Text, Convert.ToInt32(coffquan5.Value));
                totalammount += b;
                billprint.Text += " " + Coffee5.Text + "       " + "          " + coffquan5.Value + "           " + b + "\n";
                //stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, Coffee5.Text, coffquan5.Value, DateTime.Now.Date, b);
                coffquan5.Value = 0;
                Coffee5.Checked = false;
            }
            if (Coffee6.Checked == true)
            {
                var b = calculate(coffeeprice6.Text, Convert.ToInt32(coffquan6.Value));
                totalammount += b;
                billprint.Text += " " + Coffee6.Text + "       " + "          " + coffquan6.Value + "           " + b + "\n";
                //stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, Coffee6.Text, coffquan6.Value, DateTime.Now.Date, b);
                coffquan6.Value = 0;
                Coffee6.Checked = false;
            }

            
            if (tea1.Checked == true)
            {
                var b = calculate(teaprice1.Text, Convert.ToInt32(teaquan1.Value));
                totalammount += b;
                billprint.Text += " " + tea1.Text + "       " + "          " + teaquan1.Value + "           " + b + "\n";
                stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, tea1.Text, teaquan1.Value, DateTime.Now.Date, totalammount);
                teaquan1.Value = 0;
                tea1.Checked = false;

            }


            if (tea2.Checked == true)
            {
                var b = calculate(teaprice2.Text, Convert.ToInt32(teaquan2.Value));
                totalammount += b;
                billprint.Text += " " + tea2.Text + "       " + "          " + teaquan2.Value + "           " + b + "\n";
                stock22 = ((Convert.ToInt32(teaquan2.Value)) - tea22);
                databaseinsert(idvalue, tea2.Text, teaquan2.Value, DateTime.Now.Date, totalammount);

                teaquan2.Value = 0;
                tea2.Checked = false;

            }
            if (tea3.Checked == true)
            {
                var b = calculate(teaprice3.Text, Convert.ToInt32(teaquan3.Value));
                totalammount += b;
                billprint.Text += " " + tea3.Text + "     " + "       " + teaquan3.Value + "           " + b + "\n";
                stock33 = ((Convert.ToInt32(teaquan3.Value)) - tea33);
                databaseinsert(idvalue, tea3.Text, teaquan3.Value, DateTime.Now.Date, totalammount);

                teaquan3.Value = 0;
                tea3.Checked = false;

            }
            if (tea4.Checked == true)
            {
                var b = calculate(teaprice4.Text, Convert.ToInt32(teaquan4.Value));
                totalammount += b;
                billprint.Text += " " + tea4.Text + "        " + "           " + teaquan4.Value + "            " + b + "\n";
                stock44 = ((Convert.ToInt32(teaquan4.Value)) - tea44);
                databaseinsert(idvalue, tea4.Text, teaquan4.Value, DateTime.Now.Date, totalammount);

                teaquan4.Value = 0;
                tea4.Checked = false;

            }
            if (tea5.Checked == true)
            {
                var b = calculate(teaprice5.Text, Convert.ToInt32(teaquan5.Value));
                totalammount += b;
                billprint.Text += " " + tea5.Text + "       " + "          " + teaquan5.Value + "           " + b + "\n";
                stock55 = ((Convert.ToInt32(teaquan5.Value)) - tea55);
                databaseinsert(idvalue, tea5.Text, teaquan5.Value, DateTime.Now.Date, totalammount);

                teaquan5.Value = 0;
                tea5.Checked = false;

            }
            if (tea6.Checked == true)
            {
                var b = calculate(teaprice6.Text, Convert.ToInt32(teaquan6.Value));
                totalammount += b;
                billprint.Text += " " + tea6.Text + "       " + "        " + teaquan6.Value + "          " + b + "\n";
                stock66 = ((Convert.ToInt32(teaquan6.Value)) - tea66);
                databaseinsert(idvalue, tea6.Text, teaquan6.Value, DateTime.Now.Date, totalammount);

                teaquan6.Value = 0;
                tea6.Checked = false;
                idvalue++;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constring;
            SqlCommand com = new SqlCommand();
            com.CommandText = "Insert into Sales values('" + totalammount+ "','" +DateTime.Now.Date+ "')";
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            billprint.Visible = true;
            billprint.Text += "\n---------------------------------------------------------------------------------------- \n";
            billprint.Text += " Amount :\t\t\t" + totalammount + " Rs ";
            billprint.Text += "\n Service Charges :\t\t" + 150 + " Rs ";
            billprint.Text += "\n Tax Charges :\t\t\t" + 100 + " Rs ";
            billprint.Text += "\n Total Amount: \t\t\t " + (totalammount + 150+100) + " Rs ";

            billprint.Text += "\n----------------------------------------------------------------------------------------\n ";
            billprint.Text += " Order Time :   " + DateTime.Now.ToLongTimeString()+"\n";
            billprint.Text += " Order Date :   " + DateTime.Now.ToLongDateString();

            billprint.Text += "\n\n----------------------------------------------------------------------------------------\n ";
            billprint.Text += "\n\t ----------------------THANK YOU----------------------- \n\n";
        }
       
        
        private void coffeeorder_Click(object sender, EventArgs e)
        {
          
            //billprint2.Visible = true;
            billprint.Visible = false;
            teacoding();
            if (check_order_button_enter == 0)
            {
                billprint.Text += "\t================================= ";
                billprint.Text += "\n            \t \t              ROYAL CAFE  ";
                billprint.Text += "\n\t================================= \n";
                check_order_button_enter++;
            }


            if (Coffee1.Checked == true)
            {
                var b = calculate(coffeeprice1.Text, Convert.ToInt32(coffquan1.Value));
                totalammount += b;
                billprint.Text += " " + Coffee1.Text + "       " + "          " + coffquan1.Value + "           " + b + "\n";
               forcoffee1(Coffee1.Text);
                update_tea((Convert.ToInt32(coffeestock1.Text) - Convert.ToInt32(coffquan1.Value)), Coffee1.Text);
                coffquan1.Value = 1;
                Coffee1.Checked = false;
               


            }
            if (Coffee2.Checked == true)
            {
                var b = calculate(coffeeprice2.Text, Convert.ToInt32(coffquan2.Value));
                totalammount += b;
                billprint.Text += " " + Coffee2.Text + "       " + "          " + coffquan2.Value + "           " + b + "\n";
                forcoffee2(Coffee2.Text);
                update_tea((Convert.ToInt32(coffeestock2.Text) - Convert.ToInt32(coffquan2.Value)), Coffee2.Text);
                coffquan2.Value = 1;
                Coffee2.Checked = false;
            }
            if (Coffee3.Checked == true)
            {
                var b = calculate(coffeeprice3.Text, Convert.ToInt32(coffquan3.Value));
                totalammount += b;
                billprint.Text += " " + Coffee3.Text + "       " + "          " + coffquan3.Value + "           " + b + "\n";
                forcoffee3(Coffee3.Text);
                update_tea((Convert.ToInt32(coffeestock3.Text) - Convert.ToInt32(coffquan3.Value)), Coffee3.Text);
                coffquan3.Value = 1;
                Coffee3.Checked = false;
            }
            if (Coffee4.Checked == true)
            {
                var b = calculate(coffeeprice4.Text, Convert.ToInt32(coffquan4.Value));
                totalammount += b;
                billprint.Text += " " + Coffee4.Text + "       " + "          " + coffquan4.Value + "           " + b + "\n";
                forcoffee4(Coffee4.Text);
                update_tea((Convert.ToInt32(coffeestock4.Text) - Convert.ToInt32(coffquan4.Value)), Coffee4.Text);
                coffquan4.Value = 1;
                Coffee4.Checked = false;
            }
            if (Coffee5.Checked == true)
            {
                var b = calculate(coffeeprice5.Text, Convert.ToInt32(coffquan5.Value));
                totalammount += b;
                billprint.Text += " " + Coffee5.Text + "       " + "          " + coffquan5.Value + "           " + b + "\n";
                forcoffee1(Coffee5.Text);
                update_tea((Convert.ToInt32(coffeestock5.Text) - Convert.ToInt32(coffquan5.Value)), Coffee5.Text);
                coffquan5.Value = 1;
                Coffee5.Checked = false;
            }
            if (Coffee6.Checked == true)
            {
                var b = calculate(coffeeprice6.Text, Convert.ToInt32(coffquan6.Value));
                totalammount += b;
                billprint.Text += " " + Coffee6.Text + "       " + "          " + coffquan6.Value + "           " + b + "\n";
                forcoffee6(Coffee6.Text);
                update_tea((Convert.ToInt32(coffeestock6.Text) - Convert.ToInt32(coffquan6.Value)), Coffee6.Text);
                coffquan6.Value = 1;
                Coffee6.Checked = false;
            }

            idvalue++;
        }

        private void Coffeebtnpanel_Click(object sender, EventArgs e)
        {
            coffeepanel.Visible = true;
            teapanel.Visible = false;
            cakepanel.Visible = false;
        }

        private void Cakebtnpanel_Click(object sender, EventArgs e)
        {
            cakepanel.Visible = true;
            teapanel.Visible = false;
            coffeepanel.Visible = false;
        }

        private void cakebtn_Click(object sender, EventArgs e)
        {
            billprint.Visible = false;
            teacoding();
            if (check_order_button_enter == 0)
            {
                billprint.Text += "\t================================= ";
                billprint.Text += "\n            \t \t              ROYAL CAFE  ";
                billprint.Text += "\n\t================================= \n";
                check_order_button_enter++;
            }


            if (cake1.Checked == true)
            {
                var b = calculate(cakeprice1.Text, Convert.ToInt32(cakequan1.Value));
                totalammount += b;
                billprint.Text += " " + cake1.Text + "       " + "          " + cakequan1.Value + "           " + b + "\n";
                forcake1(cake1.Text);
                update_tea((Convert.ToInt32(cakeStock1.Text) - Convert.ToInt32(cakequan1.Value)), cake1.Text);

                cakequan1.Value = 1;
                cake1.Checked = false;
            }

            if (cake2.Checked == true)
            {
                var b = calculate(cakeprice2.Text, Convert.ToInt32(cakequan2.Value));
                totalammount += b;
                billprint.Text += " " + cake2.Text + "       " + "          " + cakequan2.Value + "           " + b + "\n";
                forcake2(cake2.Text);
                update_tea((Convert.ToInt32(cakeStock2.Text) - Convert.ToInt32(cakequan2.Value)), cake2.Text);
                cakequan2.Value = 1;
                cake2.Checked = false;
            }

            if (cake3.Checked == true)
            {
                var b = calculate(cakeprice3.Text, Convert.ToInt32(cakequan3.Value));
                totalammount += b;
                billprint.Text += " " + cake3.Text + "       " + "          " + cakequan3.Value + "           " + b + "\n";
                forcake3(cake3.Text);
                update_tea((Convert.ToInt32(cakeStock3.Text) - Convert.ToInt32(cakequan3.Value)), cake3.Text);

                cakequan3.Value = 1;
                cake3.Checked = false;
            }
            if (cake4.Checked == true)
            {
                var b = calculate(cakeprice4.Text, Convert.ToInt32(cakequan4.Value));
                totalammount += b;
                billprint.Text += " " + cake4.Text + "       " + "          " + cakequan4.Value + "           " + b + "\n";
                forcake4(cake4.Text);
                update_tea((Convert.ToInt32(cakeStock4.Text) - Convert.ToInt32(cakequan4.Value)), cake4.Text);

                cakequan4.Value = 1;
                cake4.Checked = false;
            }
            if (cake5.Checked == true)
            {
                var b = calculate(cakeprice5.Text, Convert.ToInt32(cakequan5.Value));
                totalammount += b;
                billprint.Text += " " + cake5.Text + "       " + "          " + cakequan5.Value + "           " + b + "\n";
                forcake5(cake5.Text);
                update_tea((Convert.ToInt32(cakeStock5.Text) - Convert.ToInt32(cakequan5.Value)), cake5.Text);

                cakequan5.Value = 1;
                cake5.Checked = false;
            }
            if (cake6.Checked == true)
            {
                var b = calculate(cakeprice6.Text, Convert.ToInt32(cakequan6.Value));
                totalammount += b;
                billprint.Text += " " + cake6.Text + "       " + "          " + cakequan6.Value + "           " + b + "\n";
                forcake6(cake6.Text);
                update_tea((Convert.ToInt32(cakeStock6.Text) - Convert.ToInt32(cakequan6.Value)), cake6.Text);

                cakequan6.Value = 1;
                cake6.Checked = false;
            }
           
            idvalue++;
        }

        private void items_Load_1(object sender, EventArgs e)
        {

        }

        private void teabtnpanel_Click(object sender, EventArgs e)
        {
            teapanel.Visible = true;
            cakepanel.Visible = false;
            coffeepanel.Visible = false;
        }

        private void logutbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            billprint.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            billprint.Cut();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            billprint.Paste();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            billprint.Copy();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        int h;

        public items(int b)
        {
           InitializeComponent();
            h = b;
            teapanel.Visible = true;
            cakepanel.Visible = false;
            coffeepanel.Visible = false;

        }
        string mesg;
        public items(string s)
        {
            InitializeComponent();
            mesg = s;
            coffeepanel.Visible = true;
            cakepanel.Visible = false;
            teapanel.Visible = false;
          

        }


        private void items_Load(object sender, EventArgs e)
        {
            cakepanel.Visible = false;
            teapanel.Visible = false;
            coffeepanel.Visible = false;
           
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            m.Show();
            this.Hide();
        }
         public void teacoding()
        {

            if (tea1.Checked == true)
            {
                var b = calculate(teaprice1.Text, Convert.ToInt32(teaquan1.Value));
                totalammount += b;
                billprint.Text += " " + tea1.Text + "       " + "          " + teaquan1.Value + "           " + b + "\n";
                stock11 = ((Convert.ToInt32(teaquan1.Value)) - tea11);
                databaseinsert(idvalue, tea1.Text, teaquan1.Value, DateTime.Now.Date, totalammount);
                teaquan1.Value = 0;
                tea1.Checked = false;
                //stock checking//

            }


            if (tea2.Checked == true)
            {
                var b = calculate(teaprice2.Text, Convert.ToInt32(teaquan2.Value));
                totalammount += b;
                billprint.Text += " " + tea2.Text + "       " + "          " + teaquan2.Value + "           " + b + "\n";
                stock22 = ((Convert.ToInt32(teaquan2.Value)) - tea22);
                databaseinsert(idvalue, tea2.Text, teaquan2.Value, DateTime.Now.Date, totalammount);

                teaquan2.Value = 0;
                tea2.Checked = false;

            }
            if (tea3.Checked == true)
            {
                var b = calculate(teaprice3.Text, Convert.ToInt32(teaquan3.Value));
                totalammount += b;
                billprint.Text += " " + tea3.Text + "     " + "       " + teaquan3.Value + "           " + b + "\n";
                stock33 = ((Convert.ToInt32(teaquan3.Value)) - tea33);
                databaseinsert(idvalue, tea3.Text, teaquan3.Value, DateTime.Now.Date, totalammount);

                teaquan3.Value = 0;
                tea3.Checked = false;

            }
            if (tea4.Checked == true)
            {
                var b = calculate(teaprice4.Text, Convert.ToInt32(teaquan4.Value));
                totalammount += b;
                billprint.Text += " " + tea4.Text + "        " + "           " + teaquan4.Value + "            " + b + "\n";
                stock44 = ((Convert.ToInt32(teaquan4.Value)) - tea44);
                databaseinsert(idvalue, tea4.Text, teaquan4.Value, DateTime.Now.Date, totalammount);

                teaquan4.Value = 0;
                tea4.Checked = false;

            }
            if (tea5.Checked == true)
            {
                var b = calculate(teaprice5.Text, Convert.ToInt32(teaquan5.Value));
                totalammount += b;
                billprint.Text += " " + tea5.Text + "       " + "          " + teaquan5.Value + "           " + b + "\n";
                stock55 = ((Convert.ToInt32(teaquan5.Value)) - tea55);
                databaseinsert(idvalue, tea5.Text, teaquan5.Value, DateTime.Now.Date, totalammount);

                teaquan5.Value = 0;
                tea5.Checked = false;

            }
            if (tea6.Checked == true)
            {
                var b = calculate(teaprice6.Text, Convert.ToInt32(teaquan6.Value));
                totalammount += b;
                billprint.Text += " " + tea6.Text + "       " + "        " + teaquan6.Value + "          " + b + "\n";
                stock66 = ((Convert.ToInt32(teaquan6.Value)) - tea66);
                databaseinsert(idvalue, tea6.Text, teaquan6.Value, DateTime.Now.Date, totalammount);

                teaquan6.Value = 0;
                tea6.Checked = false;

            }

        }



        public int calculate(string price, int value)
        {
            int x = Convert.ToInt32(price);
            int y = value;
            int z = 0;
            if (x != 0 && y != 0)
            {
                z = x * y;
            }
            else
            {
                z = 0;
            }
            return z;
        }

        // int count = 0;
        int teasection = 0;
       
///*************tea stock retrieval************/////

        public void fortea1(string itemname)
        {
           SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname+ "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
               teaStock1.Text= reader["Actual_Stock"].ToString();
            }
           
            con.Close();
        }
        public void fortea2(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                teaStock2.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void fortea3(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                teaStock3.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void fortea4(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                teaStock4.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void fortea5(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                teaStock5.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void fortea6(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                teaStock6.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
 //***********Coffee Stock Retreival********************//
        public void forcoffee1(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
               coffeestock1.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcoffee2(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                coffeestock2.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcoffee3(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                coffeestock3.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcoffee4(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                coffeestock4.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog sav = new SaveFileDialog();
            DialogResult savDialog = sav.ShowDialog();

            if (savDialog == DialogResult.OK)
            {
                File.WriteAllText(sav.FileName, billprint.Text);
            }
            else
            {
                savDialog = DialogResult.Cancel;
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult d = op.ShowDialog();
            if (d == DialogResult.OK)
            {
               billprint.Text = File.ReadAllText(op.FileName);

            }
            else
            {
                d = DialogResult.Cancel;
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            billprint.Text = "How can we help you?";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        public void forcoffee5(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                coffeestock5.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcoffee6(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                coffeestock6.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }


        //***********Cake Stock Retreival********************//
        public void forcake1(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cakeStock1.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcake2(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cakeStock2.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcake3(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cakeStock3.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcake4(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cakeStock4.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcake5(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cakeStock5.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }
        public void forcake6(string itemname)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Actual_Stock from Stock_Details where Item_Name = '" + itemname + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cakeStock6.Text = reader["Actual_Stock"].ToString();
            }

            con.Close();
        }


        public void update_tea(int stock,string name)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Stock_Details set Actual_Stock='"+stock+"' where Item_Name = '" +name+ "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Teabtn_Click(object sender, EventArgs e)
        {
            billprint.Visible = false;
            if (check_order_button_enter == 0)
            {
                billprint.Text += "\t================================= ";
                billprint.Text += "\n            \t \t              ROYAL CAFE  ";
                billprint.Text += "\n\t================================= \n";
                check_order_button_enter++;
            }
           

            if (tea1.Checked==true)
            {
                var b = calculate(teaprice1.Text,Convert.ToInt32(teaquan1.Value));
               totalammount += b; 
                billprint.Text += " " + tea1.Text + "       " + "          " + teaquan1.Value + "           "+b+"\n";
                fortea1(tea1.Text);
                int a = Convert.ToInt32(teaStock1.Text);
                int bb = Convert.ToInt32(teaquan1.Value);
               update_tea((a-bb),tea1.Text);
                //databaseinsert(idvalue,tea1.Text,teaquan1.Value, DateTime.Now.Date, totalammount);
                teaquan1.Value = 1;
                tea1.Checked = false;

                }
              

                if (tea2.Checked == true)
                {
                    var b = calculate(teaprice2.Text, Convert.ToInt32(teaquan2.Value));
                    totalammount += b;
                    billprint.Text += " " + tea2.Text + "       " + "          " + teaquan2.Value + "           " + b + "\n";
             fortea2(tea2.Text);
                update_tea((Convert.ToInt32(teaStock2.Text) - Convert.ToInt32(teaquan2.Value)), tea2.Text);
         
                teaquan2.Value = 1;
                tea2.Checked = false;

            }
            if (tea3.Checked == true)
            {
                var b = calculate(teaprice3.Text, Convert.ToInt32(teaquan3.Value));
                totalammount += b;
                billprint.Text += " " + tea3.Text + "     " + "       " + teaquan3.Value + "           " + b + "\n";
              fortea3(tea3.Text);
                update_tea((Convert.ToInt32(teaStock3.Text) - Convert.ToInt32(teaquan3.Value)), tea3.Text);
                //databaseinsert(idvalue, tea3.Text, teaquan3.Value, DateTime.Now.Date, totalammount);

                teaquan3.Value = 1;
                tea3.Checked = false;

            }
            if (tea4.Checked == true)
            {
                var b = calculate(teaprice4.Text, Convert.ToInt32(teaquan4.Value));
                totalammount += b;
                billprint.Text += " " + tea4.Text + "        " + "           " + teaquan4.Value + "            " + b + "\n";

              fortea4(tea4.Text);
                update_tea((Convert.ToInt32(teaStock4.Text) - (Convert.ToInt32(teaquan4.Value))), tea4.Text);
            

                teaquan4.Value = 1;
                tea4.Checked = false;

            }
            if (tea5.Checked == true)
            {
                var b = calculate(teaprice5.Text, Convert.ToInt32(teaquan5.Value));
                totalammount += b;
                billprint.Text += " " + tea5.Text + "       " + "          " + teaquan5.Value + "           " + b + "\n";
             fortea5(tea5.Text);
                update_tea((Convert.ToInt32(teaStock5.Text) - Convert.ToInt32(teaquan5.Value)), tea5.Text);
              //  databaseinsert(idvalue, tea5.Text, teaquan5.Value, DateTime.Now.Date, totalammount);

                teaquan5.Value = 1;
                tea5.Checked = false;

            }
            if (tea6.Checked == true)
            {
                var b = calculate(teaprice6.Text, Convert.ToInt32(teaquan6.Value));
                totalammount += b;
                billprint.Text += " " + tea6.Text + "       " + "        " + teaquan6.Value + "          " + b + "\n";
               fortea6(tea6.Text);

                update_tea((Convert.ToInt32(teaStock6.Text) - Convert.ToInt32(teaquan6.Value)), tea6.Text);
              //  databaseinsert(idvalue, tea6.Text, teaquan6.Value, DateTime.Now.Date, totalammount);
        
                    teaquan6.Value = 1;
                tea6.Checked = false;

            }
         
        }
    }
}
