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
        public ActionResult ListStudent()
        {
            List<Models.Student> student = new List<Models.Student>();

            student.Add(new Models.Student { StudentNumber = "u21588229", Name = "Lindani", Surname = "Zwane", Email = "lindani.zwane@tuks.co.za"});
            student.Add(new Models.Student { StudentNumber = "u21675947", Name = "Bob", Surname = "Dlamini", Email = "bob.dlamini@tuks.co.za" });
            student.Add(new Models.Student { StudentNumber = "u21759406", Name = "Okuhle", Surname = "Mavuso", Email = "okuhle.mavuso@tuks.co.za" });
            student.Add(new Models.Student { StudentNumber = "u21864548", Name = "Daniel", Surname = "Cardoso", Email = "daniel.cardoso@tuks.co.za" });
            student.Add(new Models.Student { StudentNumber = "u21956312", Name = "Rodrick", Surname = "Hwaire", Email = "rodrick.hwaire@tuks.co.za" });

            return View(student);
        }
    }
}