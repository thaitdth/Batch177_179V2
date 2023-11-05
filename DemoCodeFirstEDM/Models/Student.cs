using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirstEDM.Models
{
    public class Student : Person
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }
        public string Group { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

}
