using InformationandTechnologyCollege.Models;
using InformationandTechnologyCollege.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationandTechnologyCollege.Services.Business
{
    public class clsSecurityService
    {
        clsSecurityDAO daoServices = new clsSecurityDAO();


        public bool Authenticate(clsUserModel username)
        {

            return daoServices.FindByUser(username);

        }
    }
}