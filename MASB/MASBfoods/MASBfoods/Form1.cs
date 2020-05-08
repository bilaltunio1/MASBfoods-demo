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
    public partial class Form1 : Form
    {
        public static int uID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void regbt_Click(object sender, EventArgs e)
        {
            using(SqlConnection con= new SqlConnection(Connection.conString))
            {
                //adding data to user table
                String Insert="INSERT INTO userdata (User_Name,User_Password,User_Email,User_Type) VALUES (@uname,@upass,@Uemail,@type)";
                using(SqlCommand comm= new SqlCommand(Insert,con))
                {
                    comm.Parameters.AddWithValue("@uname", usrtxt.Text);
                    comm.Parameters.AddWithValue("@upass", passtxt.Text);
                    comm.Parameters.AddWithValue("@uemail", emailtxt.Text);
                    comm.Parameters.AddWithValue("@type", "Rest");

                    
                      con.Open();
                      int result= comm.ExecuteNonQuery();
                      con.Close();
                      if (result < 0)
                          MessageBox.Show(" User Registration failed");
                      else
                          MessageBox.Show("User Reistration Successful");
                   
                }
            }

            using (SqlConnection con = new SqlConnection(Connection.conString))
            {
                // retriving new user id from the user table
                
                
                using (SqlCommand comm = new SqlCommand("Select User_ID from userdata where User_Name=@uname", con))
                {
                    comm.Parameters.AddWithValue("@uname", usrtxt.Text);

                    con.Open();
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            uID = int.Parse(oReader["User_ID"].ToString());
                           
                        }

                        con.Close();
                    }           
                    con.Close();
                }
            }


            using (SqlConnection con = new SqlConnection(Connection.conString))
            {

                String InsertRest = "insert into restaurant (ID,Restaurant_Name,Location,Type) values (@id,@rest,@loc,@type)";
                using (SqlCommand comm = new SqlCommand(InsertRest, con))
                {
                    comm.Parameters.AddWithValue("@id", uID);
                    comm.Parameters.AddWithValue("@rest",resttxt.Text);
                    comm.Parameters.AddWithValue("@loc", locbox.SelectedItem.ToString());
                    comm.Parameters.AddWithValue("@type", typebox.SelectedItem.ToString());

                    con.Open();
                    int result = comm.ExecuteNonQuery();
                    con.Close();
                    if (result < 0)
                        MessageBox.Show(" Restaurant Registration failed");
                    else
                        MessageBox.Show("Restaurant Reistration Successful");

                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
