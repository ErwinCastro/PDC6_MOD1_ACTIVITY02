using System;
using System.Collections.Generic;
using System.Text;
using PDC6_MOD1_ACTIVITY02.Models;
using System.Linq;
using System.Threading.Tasks;


namespace PDC6_MOD1_ACTIVITY02.ViewModels
{
    class SubjectViewModel
    {
       public Student Info { get; set; }
        public SubjectViewModel()
        {
            Info = new Student
            {
                StudentId = "12",
                Name = "Erwin John Castro",
                CourseCode = "Cap02",
                CourseTitle = "Capstone 02 Graduation",
                Noofunits = 5,
                Date = 011020,



            };
        }

    }
}
