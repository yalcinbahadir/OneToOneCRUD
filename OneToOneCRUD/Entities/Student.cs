using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StudentDetails StudentDetails { get; set; }
    }
    public class StudentDetails
    {
        public int Id { get; set; }
        public string   Email { get; set; }
        public string Address { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
