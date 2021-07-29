using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IStudentRepository _students;
        private IStudentDetailsRepository _studentDetails;

        public UnitOfWork(IStudentRepository students, IStudentDetailsRepository studentDetails)
        {
            _students = students;
            _studentDetails = studentDetails;
        }

        public IStudentRepository StudentRepo => _students;

        public IStudentDetailsRepository StudStudentDetailsRepo => _studentDetails;
    }
}
