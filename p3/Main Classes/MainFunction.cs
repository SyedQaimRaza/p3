using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace p3
{
    public  class MainFunction
    {

        static string ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection Con = new SqlConnection(ConnectionString);
        public static int GetMaxId(string sqlstr)
        {
            int pid = 0;
            //string constr = ConfigurationManager.ConnectionStrings["ConString2"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlstr, con))
                {
                    con.Open();
                    pid = Convert.ToInt32(cmd.ExecuteScalar()) + 1;


                    con.Close();
                    return pid;
                }
            }
        }



        public static SqlDataReader SelecttData(string sqlstr)
        {
            //string constr = ConfigurationManager.ConnectionStrings["ConString2"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand(sqlstr, con);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;

        }
        public static void searchItem(BindingSource B, string q, TextBox t)
        {
            B.Filter = q + t + "%'";
        } 
    }




}
