using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InformationandTechnologyCollege.Models;
using InformationandTechnologyCollege.Controllers;

namespace InformationandTechnologyCollege.Tests.Controllers
{
    [TestClass]
    public class CourseTesting
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            CourseController AllCourses = new CourseController();
            //test to see if it exists
            Assert.IsNotNull(AllCourses);
        }
    }
}
