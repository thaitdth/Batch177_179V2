using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemoFramework
{
    public class Context : DbContext
    {
        public Context() : base("name=connectionString") { }
        public DbSet<Person> People { get; set; }
    }
}
