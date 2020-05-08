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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {

            if (usrtxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Please insert details");
            }
            else
            {
                if (Connection.checklogin(usrtxt.Text, passtxt.Text))
                {
                   // MessageBox.Show("Login Successful  ");
                    if (Connection.loginType == "Rest")
                    {
                        //*************
                        using (SqlConnection con = new SqlConnection(Connection.conString))
                        {


                            using (SqlCommand comm = new SqlCommand("select Restaurant_Name from restaurant where ID=@id", con))
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
                                        Connection.Nameaccess = (oReader["Restaurant_Name"].ToString());

                                    }

                                    con.Close();
                                }
                                con.Close();
                            }
                        }


                        //************
                        restaurantPanel restp = new restaurantPanel();

                        this.Visible = false;
                        restp.Show();
                    }

                    else if (Connection.loginType == "Cust")
                    {
                        customerPanel custp = new customerPanel();

                        //*************
                        using (SqlConnection con = new SqlConnection(Connection.conString))
                        {


                            using (SqlCommand comm = new SqlCommand("select Customer_Name from customer where ID=@id", con))
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
                                        Connection.Nameaccess = (oReader["Customer_Name"].ToString());

                                    }

                                    con.Close();
                                }
                                con.Close();
                            }
                        }


                        //************



                        this.Visible = false;
                        custp.Show();


                    }

                    else if (Connection.loginType == "Ride")
                    {
                        riderPanel ridep = new riderPanel();

                        //*************
                        using (SqlConnection con = new SqlConnection(Connection.conString))
                        {


                            using (SqlCommand comm = new SqlCommand("select Rider_Name from rider where ID=@id", con))
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
                                        Connection.Nameaccess = (oReader["Rider_Name"].ToString());

                                    }

                                    con.Close();
                                }
                                con.Close();
                            }
                        }


                        //************



                        this.Visible = false;
                        ridep.Show();
                    }


                }

                else
                    MessageBox.Show("Incorrect Login Details....! ");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                timer1.Stop();
                registertype rt = new registertype();

                rt.Show();
                this.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
