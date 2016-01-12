using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestOfTesters.Models
{
    public class FormModel
    {
        // This model is intentionally incomplete, only few props are actually used for some logic. 

        // Used section
        private string fullName;       

        public string StudentFirstName { get; set; }
        public string StudentMiddleName { get; set; }
        public string StudentLastName { get; set; }

        public string FullName {
            get { return fullName; }
            set { fullName = value; }
        }

        // Yet unused prop pool
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int YearOfStudy { get; set; }

        public string Faculty { get; set; }
        public string TeacherFullName { get; set; }

    }
}