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
namespace MASBfoods
{
    public partial class customerPanel : Form
    {
        public static List<string> restid= new List<string>();
        int total = 0;
        public static string Address;
        public static string rest;
        string currentstatus = "";
        public customerPanel()
        {
            InitializeComponent();
        }

        private void customerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void locbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loc = locbox.SelectedItem.ToString();
            string rest = "select Restaurant_Name,ID from restaurant where Location=@loc";
            using (SqlConnection con = new SqlConnection(Connection. conString))
            {



                using (SqlCommand comm = new SqlCommand(rest, con))
                {
                    comm.Parameters.AddWithValue("@loc", loc);

                    con.Open();
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        for (int i = restbox.Items.Count - 1; i >= 0; i--)
                        {
                            restbox.SelectedIndex = i;
                            restbox.Items.Remove(orderbox.SelectedItem);
                        }
                        while (oReader.Read())
                        {
                            restbox.Items.Add(oReader["Restaurant_Name"].ToString());
                            restid.Add(oReader["ID"].ToString());
                        }

                        con.Close();
                    }
                    con.Close();
                }
            }
        }

        private void restbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (restid.Count > 0)
            {
                rest = restid[restbox.SelectedIndex];
                using (SqlConnection con = new SqlConnection(Connection.conString))
                {
                    // retriving item list

                    using (SqlCommand comm = new SqlCommand("select Item_Name ,Price from items where Restaurant_ID=@id", con))
                    {
                        comm.Parameters.AddWithValue("@id", rest);

                        con.Open();
                        using (SqlDataReader oReader = comm.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(oReader);

                            this.dataGridView1.DataSource = dt;
                            //DataGridViewColumn dgw = new DataGridViewTextBoxColumn();
                            //dgw.HeaderText = "Quantity";
                            //dgw.ReadOnly = true;
                            //int colindex = dataGridView1.Columns.Add(dgw);
                            //while (oReader.Read())
                            //{
                            //    uID = int.Parse(oReader["User_ID"].ToString());
                            //    Username = oReader["User_Name"].ToString();
                            //    Password = oReader["User_Password"].ToString();
                            //    loginType = oReader["User_Type"].ToString();
                            //}

                            con.Close();
                        }
                        con.Close();
                    }
                }
                Column1.Visible = true;
                Column2.Visible = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addcartbt_Click(object sender, EventArgs e)
        {
            //Experimental
            if(restbox.SelectedIndex>=0)
            richTextBox1.Text += "*****"+restbox.SelectedItem.ToString()+"*****\n-----***-----\n";
            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[Column1.Name].Value) == true)
                {
                    //row.Cells[Column2.Name].ReadOnly = false;
                    rows_with_checked_column.Add(row);
                    if (rows_with_checked_column.Count > 0)
                    {
                        richTextBox1.Text += row.Cells[mASBfoodsDataSet.items.Item_NameColumn.ColumnName].Value.ToString() + "~" + row.Cells[Column2.Name].Value.ToString() + "~" + Int32.Parse(row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString()) * Int32.Parse(row.Cells[Column2.Name].Value.ToString()) + "\n";
                        //label2.Text= row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString();
                        total += Int32.Parse(row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString()) * Int32.Parse(row.Cells[Column2.Name].Value.ToString());
                        //label2.Text = total.ToString();
                    }
                }
            }

            restbox_SelectedIndexChanged(sender, e);


        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[Column1.Name].Value) == true)
                {
                    row.Cells[Column2.Name].ReadOnly = false;
                    //rows_with_checked_column.Add(row);
                    ////label2.Text= row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString();
                    //total += Int32.Parse(row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString());
                    //label2.Text = total.ToString();
                }
                else if (Convert.ToBoolean(row.Cells[Column1.Name].Value) == false)
                {
                    row.Cells[Column2.Name].ReadOnly = true;
                    //rows_with_checked_column.Add(row);
                    ////label2.Text= row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString();
                    //total += Int32.Parse(row.Cells[mASBfoodsDataSet.items.PriceColumn.ColumnName].Value.ToString());
                    //label2.Text = total.ToString();
                }
            }
        }

        private void checkoutbt_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                richTextBox1.Text += "Total Amount: " + total.ToString() + "\nAddress: " + Address + "\n" + DateTime.Now.ToString();
                bool ifadded = Connection.addOrders(richTextBox1.Text, rest);
                if (ifadded)
                {
                    MessageBox.Show("Unsuccessful");
                }
                else
                    MessageBox.Show("successful");

                customerPanel_Load(sender, e);
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome! " + Connection.Nameaccess;
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {


                using (SqlCommand comm = new SqlCommand("select Order_ID from orders where Customer_ID=@id AND Order_Status <>'Delivered'", con))
                {
                    comm.Parameters.AddWithValue("@id", Connection.uID);

                    con.Open();
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        //DataTable dt = new DataTable();
                        //dt.Load(oReader);

                        //this.dataGridView2.DataSource = dt;
                        for (int i = orderbox.Items.Count - 1; i >= 0; i--)
                        {
                            orderbox.SelectedIndex = i;
                            orderbox.Items.Remove(orderbox.SelectedItem);
                        }
                        while (oReader.Read())
                        {
                            orderbox.Items.Add(oReader["Order_ID"].ToString());

                        }

                        con.Close();
                    }
                    con.Close();
                }

                //Experimental

                using (SqlCommand comm = new SqlCommand("select Address from customer where ID=@id ", con))
                {
                    comm.Parameters.AddWithValue("@id", Connection.uID);

                    con.Open();
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        //DataTable dt = new DataTable();
                        //dt.Load(oReader);

                        //this.dataGridView2.DataSource = dt;
                        
                        while (oReader.Read())
                        {
                            Address=(oReader["Address"].ToString());

                        }

                        con.Close();
                    }
                    con.Close();
                }


            }
        }

        private void orderbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderid = orderbox.SelectedItem.ToString();
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {


                using (SqlCommand comm = new SqlCommand("select Order_Detail,Order_Status from orders where Order_ID=@id AND Order_Status<>'Delivered'", con))
                {
                    comm.Parameters.AddWithValue("@id", orderid);

                    con.Open();
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        //DataTable dt = new DataTable();
                        //dt.Load(oReader);

                        //this.dataGridView2.DataSource = dt;
                        while (oReader.Read())
                        {
                            richTextBox2.Text = (oReader["Order_Detail"].ToString()) + "\nOrder Status:" + oReader["Order_Status"].ToString() + "\n*****";
                            currentstatus = oReader["Order_Status"].ToString();
                        }

                        con.Close();
                    }
                    con.Close();
                }
                if (currentstatus == "Delivery in Progress")
                    button1.Enabled = true;
                else if (currentstatus != "Delivery in Progress")
                {
                    button1.Enabled = false;
                    //MessageBox.Show("Order is still pending");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isadded = Connection.Delivered(orderbox.SelectedItem.ToString());
            if (isadded)
            {
                MessageBox.Show("Failed to update");
            }
            else
                MessageBox.Show("Enjoy The Meal");

            customerPanel_Load(sender, e);
        }

        private void logoutbt_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Visible = false;
            lg.Show();
        }

        private void reloadbt_Click(object sender, EventArgs e)
        {
            //customerPanel_Load(sender, e);
            if(restbox.Items.Count>0)
            restbox_SelectedIndexChanged(sender, e);
            total = 0;
            richTextBox1.Text = "";
        }
    }
}
