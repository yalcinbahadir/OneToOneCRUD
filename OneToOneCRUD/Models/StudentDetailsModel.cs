using OneToOneCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Models
{
    public class StudentDetailsModel
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string StudentId { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
