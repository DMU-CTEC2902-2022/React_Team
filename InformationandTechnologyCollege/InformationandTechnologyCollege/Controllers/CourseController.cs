using InformationandTechnologyCollege.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace InformationandTechnologyCollege.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View(_courses1);
        }

        private List<Course> _courses1 = new List<Course>()
        {
            new Course
            {
                CourseId = 1,
                Code = "COS1903",
                Name = "Scala Programming",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

            },
            new Course
            {
                CourseId = 2,
                Code = "COS1920",
                Name = "Database Management",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

            },
            new Course
            {
                CourseId = 3,
                Code = "COS2905",
                Name = "Object Oriented Programming (Java)",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

            }

        };

        // GET: Details/id
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Course selectedCourse = _courses1.First(p => p.CourseId == id);

            if (selectedCourse == null) return new HttpNotFoundResult();
            return View(selectedCourse);
        }

        // GET: Edit/id
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Course selectedCourse = _courses1.First(p => p.CourseId == id);
            if (selectedCourse == null) return new HttpNotFoundResult();
            return View(selectedCourse);
        }

        // POST: Edit
        [HttpPost]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(course.Name);
                Debug.WriteLine(course.Description);
                return RedirectToAction("Index");
            }
            else
            {
                return View(course);
            }

        }
    }
}