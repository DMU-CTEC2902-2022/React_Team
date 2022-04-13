using InformationandTechnologyCollege.Models;
using  InformationandTechnologyCollege.Services.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InformationandTechnologyCollege.Services.Data
{
    public class clsSecurityDAO
    {
        // connect to the databasse
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C63FBF11415D3B6654A2BEA305EA452A_ORMATIONANDTECHNOLOGYCOLLEGE\APP_DATA\ASPNET-INFORMATIONANDTECHNOLOGYCOLLEGE-20220217094051.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal bool FindByUser(clsUserModel username)
        {
            // nothing was found in this query
            bool success = false;

            //sql expression
            string queryString = "SELECT * FROM dbo.tblLogin WHERE Email = @Email AND Password = @Password";

            // creates and open the connection to the Db inside using a block
            //this makes sure that all resources are closed correctly when the query is finished
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Command and parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);
                // linking @Email to .Email
                command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 128).Value = username.Email;
                command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, int.MaxValue).Value = username.Password;
              
                //open the Db and run commands
                try
                {
                    //opens connection the db
                    connection.Open();
                    //this makes the tbl readible to the system
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                        while (reader.Read())
                        {

                            //this is now it reads the extra data in the tbl
                            username.Modules = reader.GetString(4);
                            username.AccountType = reader.GetString(3);
                            


                        }
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);

                }
                return success;
            }


            //clsSecurityService securityService = new clsSecurityService();
            //{
            //    //return (username.Email == "Admin@gmail.com" && username.Password == "Qwerty123@");
            //    //////code above is a hardcoded login, great for testing pages work, terrible for a live site//////
            //}
        }
    }
}