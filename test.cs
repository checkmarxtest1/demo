using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class test
    {
       public void  XSS()
       {
            Response.Write(Request.Form["data"]);
       }

       public void Privacy()
       {
           string password = "123456987987";
       }

       public void SQLi()
       {
           using (SqlConnection c = new SqlConnection())
           {

               SqlCommand cmd = new SqlCommand("SELECT * FROM Table WHERE " + Request.Form["data"]);
               cmd.ExecuteNonQuery();
           
           }
       }

       public void SQLi2()
       {
           using (SqlConnection c = new SqlConnection())
           {

               SqlCommand cmd = new SqlCommand("SELECT * FROM Table WHERE " + Request.Form["data"]);
               cmd.ExecuteNonQuery();
           
           }
       }

       
    }
}
