using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Models
{
    public class Faculty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }
        
    }
    public class Department
    {
        public String DepID { get; set; }
        public String name { get; set; }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public String Age { get; set; }


    }
    public class Course
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int chour { get; set; }

    }

}