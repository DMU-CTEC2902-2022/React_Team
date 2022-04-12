using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InformationandTechnologyCollege.Models;
using InformationandTechnologyCollege.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

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

        [TestMethod]
        public void Index()
        {
            // Arrange
            CourseController AllCourses = new CourseController();

            // Act
            ViewResult result = AllCourses.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index1()
        {
            // Arrange
            CourseController AllCourses = new CourseController();

            // Act
            ViewResult result = AllCourses.Index1() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index2()
        {
            // Arrange
            CourseController AllCourses = new CourseController();

            // Act
            ViewResult result = AllCourses.Index2() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DetailsValid()
        {
            // Arrange
            CourseController AllCourses = new CourseController();

            //Valid ID data
            int id = 14;

            // Act
            ViewResult result = AllCourses.Details(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EditValid()
        {
            // Arrange
            CourseController AllCourses = new CourseController();

            //Valid ID data
            int id = 14;

            // Act
            ViewResult result = AllCourses.Details(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CoruseExists()
        {
            //create an instance of the class we want to create
            Course Courses = new Course();
            //test to see if it exists
            Assert.IsNotNull(Courses);
        }

        [TestMethod]
        public void CoursesCollection()
        {
            //create an instance of the class we want to create
            List<Course> Course = new List<Course>();
            //test to see if it exists
            Assert.IsNotNull(Course);
        }
    }
}
