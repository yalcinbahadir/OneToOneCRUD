using Microsoft.EntityFrameworkCore;
using OneToOneCRUD.Data;
using OneToOneCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStudent(Student student)
        {
            _context.Students.Add(student);
            return _context.SaveChanges() > 0;
           
        }

        public bool DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
            return _context.SaveChanges() > 0;
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public List<Student> GetStudentsWithDetails()
        {
            return _context.Students.Include(s=>s.StudentDetails).ToList();
        }

        public Student GetStudentWithDetail(int id)
        {
            return _context.Students.Include(s=>s.StudentDetails).FirstOrDefault(s=>s.Id==id);
        }

        public bool UpdateStudent(Student student)
        {
            var s = GetStudentById(student.Id);
            if (s is not null)
            {
                s.Name = student.Name;
            }
            return _context.SaveChanges() > 0;
        }
    }
}
