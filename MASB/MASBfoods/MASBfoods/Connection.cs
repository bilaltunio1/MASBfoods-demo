using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MASBfoods
{
    class Connection
    {
        public static string conString = "Data Source=BAT-LAPTOP\\SQLEXPRESS;Initial Catalog=MASBfoods;Integrated Security=True";
        // public static SqlConnection con;
        public static string loginType = "",Nameaccess="";
        public static int uID;
        public static bool checklogin(string username, string password)
        {
            string login = "SELECT User_Name, User_Password, User_ID,User_Type from userdata where User_Name=@uname";
            string Username="", Password="";
            
            using (SqlConnection con = new SqlConnection(conString))
            {
                


                using (SqlCommand comm = new SqlCommand(login, con))
                {
                    comm.Parameters.AddWithValue("@uname", username);

                    con.Open();
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            uID = int.Parse(oReader["User_ID"].ToString());
                            Username = oReader["User_Name"].ToString();
                            Password = oReader["User_Password"].ToString();
                            loginType = oReader["User_Type"].ToString();
                        }

                        con.Close();
                    }
                    con.Close();
                }
            }

            if (username == Username && password == Password)
            {

                return true;
               
            }

            return false;
        }






        // adding items to resturant

        public static bool addItems(string itemName,string price)
        {
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {
            String Insert = "INSERT INTO items (Item_Name,Price,Restaurant_ID) VALUES (@iname,@iprice,@resid)";
                using (SqlCommand comm = new SqlCommand(Insert, con))
                {
                    comm.Parameters.AddWithValue("@iname", itemName);
                    comm.Parameters.AddWithValue("@iprice",price);
                    comm.Parameters.AddWithValue("@resid", uID);


                    con.Open();
                    int result = comm.ExecuteNonQuery();
                    con.Close();
                    if (result < 0)
                        return true;
                    else
                        return false;

                }
            }
        }

        //adding order to ordertable
        public static bool addOrders(string order, string RestID)
        {
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {
                String Insert = "INSERT INTO orders(Restaurant_ID,Customer_ID,Order_Detail,Order_Status) VALUES (@resid,@custid,@orderdet,@orderst)";
                using (SqlCommand comm = new SqlCommand(Insert, con))
                {
                    comm.Parameters.AddWithValue("@resid", RestID);
                    comm.Parameters.AddWithValue("@custid", uID);
                    comm.Parameters.AddWithValue("@orderdet", order);
                    comm.Parameters.AddWithValue("@orderst", "Pending");

                    con.Open();
                    int result = comm.ExecuteNonQuery();
                    con.Close();
                    if (result < 0)
                        return true;
                    else
                        return false;

                }
            }
        }
    
            //rider request
        public static bool riderRequest(string rid,string orderid)
        {
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {
                String Insert = "Update orders set Order_Status='Rider Request', Rider_ID=@rid where Order_ID=@oid";
                using (SqlCommand comm = new SqlCommand(Insert, con))
                {
                    comm.Parameters.AddWithValue("@rid", rid);
                    comm.Parameters.AddWithValue("@oid", orderid);
                    
                    con.Open();
                    int result = comm.ExecuteNonQuery();
                    con.Close();
                    if (result < 0)
                        return true;
                    else
                        return false;

                }
            }

        }
        //Rider apprical
        public static bool RiderApprove(string orderid)
        {
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {
                String Insert = "Update orders set Order_Status='Delivery in Progress'where Order_ID=@oid";
                using (SqlCommand comm = new SqlCommand(Insert, con))
                {
                    
                    comm.Parameters.AddWithValue("@oid", orderid);

                    con.Open();
                    int result = comm.ExecuteNonQuery();
                    con.Close();
                    if (result < 0)
                        return true;
                    else
                        return false;

                }
            }

        }
        //food delivered
        public static bool Delivered(string orderid)
        {
            using (SqlConnection con = new SqlConnection(Connection.conString))
            {
                String Insert = "Update orders set Order_Status='Delivered'where Order_ID=@oid";
                using (SqlCommand comm = new SqlCommand(Insert, con))
                {

                    comm.Parameters.AddWithValue("@oid", orderid);

                    con.Open();
                    int result = comm.ExecuteNonQuery();
                    con.Close();
                    if (result < 0)
                        return true;
                    else
                        return false;

                }
            }

        }

    }


    // Rider Request

    
}
