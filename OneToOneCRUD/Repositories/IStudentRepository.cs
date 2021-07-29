using OneToOneCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        List<Student> GetStudentsWithDetails();
        Student GetStudentById(int id);
        Student GetStudentWithDetail(int id);
        bool AddStudent(Student student);
        bool DeleteStudent(Student student);
        bool UpdateStudent(Student student);
    }
}
