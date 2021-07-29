using Microsoft.EntityFrameworkCore;
using OneToOneCRUD.Data;
using OneToOneCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Repositories
{
    public class StudentDetailsRepository : IStudentDetailsRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentDetailsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStudentDetails(StudentDetails details)
        {
            _context.StudentDetails.Add(details);
            return _context.SaveChanges()>0;
        }

        public bool DeleteStudentDetails(StudentDetails details)
        {
            _context.StudentDetails.Remove(details);
            return _context.SaveChanges() > 0;
        }

        public List<StudentDetails> GetStudentDetails()
        {
            return _context.StudentDetails.Include(sd=>sd.Student).ToList();
        }

        public StudentDetails GetStudentDetailsById(int id)
        {
            return _context.StudentDetails.Find(id);
        }

        public bool UpdateStudentDetails(StudentDetails details)
        {
            var sdetails = GetStudentDetailsById(details.Id);
            if (sdetails is not null)
            {
                sdetails.Email = details.Email;
                sdetails.Address = details.Address;
            }

            return _context.SaveChanges() > 0;
        }
    }
}
