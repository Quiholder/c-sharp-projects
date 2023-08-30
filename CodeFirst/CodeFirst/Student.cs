using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Student
    {
        public class Students
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            

        }
        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Post> Posts { get; set; }
        }
    }
}
