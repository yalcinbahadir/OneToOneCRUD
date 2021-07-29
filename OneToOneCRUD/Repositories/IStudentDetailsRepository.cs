using OneToOneCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Repositories
{
    public interface IStudentDetailsRepository
    {
        List<StudentDetails> GetStudentDetails();
        StudentDetails GetStudentDetailsById(int id);
        bool AddStudentDetails(StudentDetails details);
        bool DeleteStudentDetails(StudentDetails details);
        bool UpdateStudentDetails(StudentDetails details);
    }
}
