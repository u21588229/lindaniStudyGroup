using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lindaniStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Models.Student> student = new List<Models.Student>();

            student.Add(new Models.Student { StudentNumber = "u21588229", Name = "Lindani", Surname = "Zwane", Email = "lindani.zwane@tuks.com"});
            student.Add(new Models.Student { StudentNumber = "u21675947", Name = "Bob", Surname = "Dlamini", Email = "john.dlamini@tuks.com" });
            student.Add(new Models.Student { StudentNumber = "u21759406", Name = "Okuhle", Surname = "Mavuso", Email = "okuhle.mavuso@tuks.com" });
            student.Add(new Models.Student { StudentNumber = "u21864848", Name = "Daniel", Surname = "Cardoso", Email = "daniel.cardoso@tuks.com" });
            student.Add(new Models.Student { StudentNumber = "u21956302", Name = "Rodrick", Surname = "Hwaire", Email = "rodrick.Hwaire@tuks.com" });

            return View(student);
        }
    }
}