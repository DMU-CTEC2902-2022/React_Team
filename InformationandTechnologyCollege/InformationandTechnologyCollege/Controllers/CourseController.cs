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

        // GET: Course
        public ActionResult Index1()
        {
            return View(_courses2);
        }

        // GET: Course
        public ActionResult Index2()
        {
            return View(_courses3);
        }

        private List<Course> _courses1 = new List<Course>()
        {
            new Course
            {
                CourseId = 1,
                Code = "COS1903",
                Name = "Scala Programming",
                Description = "Play Scala enables you to use the Scala language for your application keeping key properties of the Play framework. It uses a more functional and Scala idiomatic style of programming without giving up on simplicity and developer friendliness.",

            },
            new Course
            {
                CourseId = 2,
                Code = "COS1920",
                Name = "Database Management",
                Description = "A module is a collection of declarations, statements, and procedures that are stored together as a unit. A module can be either a class module or a standard module. Class modules are attached to forms or reports, and usually contain procedures that are specific to the form or report they're attached to.",

            },
            new Course
            {
                CourseId = 3,
                Code = "COS2905",
                Name = "Object Oriented Programming (Java)",
                Description = "This module teaches the fundamental ideas behind the object-oriented approach to programming through the widely used Java programming language. Concentrating on aspects of Java that best demonstrate object-oriented principles and good practice, you'll gain a solid basis for further study of the Java language and object-oriented software development. Some experience in writing computer programs is essential.",

            },
            new Course
            {
                CourseId = 4,
                Code = "COS2910",
                Name = "Database Management",
                Description = "A module is a collection of declarations, statements, and procedures that are stored together as a unit. A module can be either a class module or a standard module. Class modules are attached to forms or reports, and usually contain procedures that are specific to the form or report they're attached to.",

            },
            new Course
            {
                CourseId = 5,
                Code = "COS3911",
                Name = "Mobile Application",
                Description = "Modules provide a container for your app's source code, resource files, and app level settings, such as the module-level build file and Android manifest file. Each module can be independently built, tested, and debugged. Android Studio uses modules to make it easy to add new devices to your project.",

            },
            new Course
            {
                CourseId = 6,
                Code = "IMAT3611",
                Name = "Computer Ethics and Privacy",
                Description = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers. Ethics is a reference to a sense of what is right and wrong.",

            },
            new Course
            {
                CourseId = 7,
                Code = "COS3451",
                Name = "Development Project",
                Description = "A module description provides detailed information about the module and its supported components, which is accessible in different manners.",

            }

        };

        private List<Course> _courses2 = new List<Course>()
        {
            new Course
            {
                CourseId = 8,
                Code = "SE3906",
                Name = "Interaction Design",
                Description = "Interaction Design (IxD) is the design of interactive products and services in which a designer's focus goes beyond the item in development to include the way users will interact with it.",

            },
            new Course
            {
                CourseId = 9,
                Code = "SE3410",
                Name = "Web Application Penetration Testing",
                Description = "A web application penetration test is a type of ethical hacking engagement designed to assess the architecture, design and configuration of web applications. Assessments are conducted to identify cyber security risks that could lead to unauthorised access and/or data exposure.",

            },
            new Course
            {
                CourseId = 10,
                Code = "SE3406",
                Name = "Fuzzy Logic & Knowledge Based Systems",
                Description = "In fuzzy logic systems, the fuzzy knowledge base represents the facts of the rules and linguistic variables based on the fuzzy set theory so that the knowledge base sytems will allow approximate reasoning.",

            },
            new Course
            {
                CourseId = 11,
                Code = "SE3613",
                Name = "Data Mining",
                Description = "Data mining is the computational process of discovering patterns in data sets involving methods at the intersection of artificial intelligence, machine learning, statistics, and data management.",

            },
            new Course
            {
                CourseId = 12,
                Code = "SE3614",
                Name = "Big Data & Business Models",
                Description = "Companies with data-driven business models base their core business on data. This focus, or dependence, on data can affect all dimensions of a business model; the value proposition as well as value added or the revenue model. Value added is generated from data by making data the company's key resource.",

            },
            new Course
            {
                CourseId = 13,
                Code = "IMAT3611",
                Name = "Computer Ethics and Privacy",
                Description = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers. Ethics is a reference to a sense of what is right and wrong.",

            },
            new Course
            {
                CourseId = 14,
                Code = "COS3451",
                Name = "Development Project",
                Description = "A module description provides detailed information about the module and its supported components, which is accessible in different manners.",

            }

        };

        private List<Course> _courses3 = new List<Course>()
        {
            new Course
            {
                CourseId = 15,
                Code = "SE3901",
                Name = "C Programming",
                Description = "Modular programming groups related sets of functions together into a module. The module is divided into an interface and an implementation. The module exports the interface; clients modules import the interface so that they can access the functions in the module.",

            },
            new Course
            {
                CourseId = 16,
                Code = "SE3902",
                Name = "Computer Law and Cyber Security Management",
                Description = "Cybersecurity management is an organisation's strategic-level capability to protect information resources and competitive advantage in a complex and evolving threat landscape.",

            },
            new Course
            {
                CourseId = 17,
                Code = "SE3903",
                Name = "Linux Security",
                Description = "Linux Security Modules (LSM) is a framework allowing the Linux kernel to support without bias a variety of computer security models. LSM is licensed under the terms of the GNU General Public License and is a standard part of the Linux kernel since Linux 2.6.",

            },
            new Course
            {
                CourseId = 18,
                Code = "SE3904",
                Name = "Cyber Threat Intelligence and Incident Response",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

            },
            new Course
            {
                CourseId = 19,
                Code = "SE3905",
                Name = "Malware Analysis",
                Description = "Cyber intelligence analysts utilize threat intelligence to mitigate any potential data threats and defend data. Moreover, they compile reports that identify ways for their organizations to pinpoint and prepare for potential threats.",

            },
            new Course
            {
                CourseId = 20,
                Code = "IMAT3611",
                Name = "Computer Ethics and Privacy",
                Description = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers. Ethics is a reference to a sense of what is right and wrong.",

            },
            new Course
            {
                CourseId = 21,
                Code = "COS3451",
                Name = "Development Project",
                Description = "A module description provides detailed information about the module and its supported components, which is accessible in different manners.",

            }

        };

        // GET: Details/id
        public ActionResult Details(int? id)
        {
            Course selectedCourse;
            if (id < 8)
            {
                if (id == null) return new HttpNotFoundResult();
                selectedCourse = _courses1.First(p => p.CourseId == id);

                if (selectedCourse == null) return new HttpNotFoundResult();
                return View(selectedCourse);
            }
            else if (id >= 8 && id < 15)
            {
                if (id == null) return new HttpNotFoundResult();
                selectedCourse = _courses2.First(p => p.CourseId == id);

                if (selectedCourse == null) return new HttpNotFoundResult();
                return View(selectedCourse);
            }
            else
            {
                if (id == null) return new HttpNotFoundResult();
                selectedCourse = _courses3.First(p => p.CourseId == id);

                if (selectedCourse == null) return new HttpNotFoundResult();
                return View(selectedCourse);
            }

        }

        // GET: Edit/id
        public ActionResult Edit(int? id)
        {
            Course selectedCourse;
            if (id < 8)
            {
                if (id == null) return new HttpNotFoundResult();
                selectedCourse = _courses1.First(p => p.CourseId == id);

                if (selectedCourse == null) return new HttpNotFoundResult();
                return View(selectedCourse);

            }
            else if (id >= 8 && id < 15)
            {

                if (id == null) return new HttpNotFoundResult();
                selectedCourse = _courses2.First(p => p.CourseId == id);

                if (selectedCourse == null) return new HttpNotFoundResult();
                return View(selectedCourse);
            }
            else 
            {
                if (id == null) return new HttpNotFoundResult();
                selectedCourse = _courses3.First(p => p.CourseId == id);

                if (selectedCourse == null) return new HttpNotFoundResult();
                return View(selectedCourse);
            }
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