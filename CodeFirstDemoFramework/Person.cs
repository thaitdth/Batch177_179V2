using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoFramework
{
    public class Person
    {
        public int PersonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
