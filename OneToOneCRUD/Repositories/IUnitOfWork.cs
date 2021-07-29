using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Repositories
{
    public interface IUnitOfWork
    {
        public IStudentRepository StudentRepo { get;}
        public IStudentDetailsRepository StudStudentDetailsRepo { get; }
    }
}
