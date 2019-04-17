using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vplproject1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cake_menus(object sender, EventArgs e)
        {

            items cakeitems = new items();
            cakeitems.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
        }

        private void teapicbox_Click(object sender, EventArgs e)
        {
            items cakei = new items(4);
            cakei.Show();
            this.Hide();

        }

        private void coffeepicbox_Click(object sender, EventArgs e)
        {
            items cakeim = new items("hi");
            cakeim.Show();
            this.Hide();
        }
    }
}
