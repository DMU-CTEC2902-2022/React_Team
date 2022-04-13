using InformationandTechnologyCollege.Models;
using  InformationandTechnologyCollege.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationandTechnologyCollege.Services.Data
{
    public class clsSecurityDAO
    {
        // connect to the databasse
        string connectionString = "Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=App_Data\aspnet-InformationandTechnologyCollege-20220217094051.mdf;Initial Catalog=aspnet-InformationandTechnologyCollege-20220217094051;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        internal bool FindByUser(clsUserModel username)
        {

            bool success = false;

            //clsSecurityService securityService = new clsSecurityService();
            //{

            //    //if (username.Email == "Admin@gmail.com" && username.Password == "Qwert123@")
            //    //{

            //    //    return true;

            //    //}
            //    //else
            //    //{

            //    //    return false;

            //    //}
            //    ///^^^^^old version of what is below, new code is cleaner but im keeping the old one in as both an example or if somthing breaks
            //    //return (username.Email == "Admin@gmail.com" && username.Password == "Qwerty123@");
            //    ////////////////code above is a hardcoded login, great for testing pages work, terrible for a live site//////////////////////////

            //}
        }
    }
}