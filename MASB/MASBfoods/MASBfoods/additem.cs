using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASBfoods
{
    public partial class additem : Form
    {
        public additem()
        {
            InitializeComponent();
        }

        private void addbt_Click(object sender, EventArgs e)
        {
           bool itemadded= Connection.addItems(itemtxt.Text, pricetxt.Text);
            if(itemadded)
                MessageBox.Show("Could not add item to list");
                
                    else
                MessageBox.Show("Item added successfully");

            this.Visible = false;

        }

        private void additem_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
