using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoginScreen
{

       class Program
    {
          public static void Main()
        {
            SqlConnection conn = new SqlConnection(@"Server = LAPTOP-JFIAGS6G\SQLEXPRESS ; Database = TIT ; Integrated Security = SSPI ; TrustServerCertificate = True");
            SqlCommand myCommand = new SqlCommand();

                          Console.WriteLine("Enter Your username and passward");
            string username=Console.ReadLine();
            string passward= Console.ReadLine();
           string valid;
            string passward_db;
            conn.Open();
            var sql = "select * from Login WHERE username='"+ username+"'   "; 
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
             DataTable dt = new DataTable();
            adapter.Fill(dt);
             conn.Close();
            if (dt.Rows.Count==0)
            {
                Console.WriteLine("user dosnt exist");
                Console.ReadKey();
                return;

            }    
            passward_db = dt.Rows[0]["password"].ToString();
            valid = dt.Rows[0]["Valid"].ToString();
            if (passward==passward_db)
            {
                if (valid== "Yes")
                {
                    Console.WriteLine("You Are Loged in ");
                }
                else
                {
                    Console.WriteLine("user is inacteve");
                    Console.ReadKey();
                    return;

                }
            }
            else
            {

                Console.WriteLine("Wrong passward");
                Console.ReadKey();
                return;
            }

            Console.ReadKey();
        }
        
            }
        }

