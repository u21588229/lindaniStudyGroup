using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lindaniStudyGroup.Models
{
	public class Student
	{

		[Display(Name = "STUDENT NUMBER")]
		public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "EMAIL")]
        public string Email { get; set; }

    }
}