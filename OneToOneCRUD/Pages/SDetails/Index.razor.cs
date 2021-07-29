using Microsoft.AspNetCore.Components;
using OneToOneCRUD.Entities;
using OneToOneCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Pages.SDetails
{
    public partial class Index
    {
        public List<StudentDetails> Details { get; set; } = new List<StudentDetails>();
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }

        protected override void OnInitialized()
        {
            Details = UnitOfWork.StudStudentDetailsRepo.GetStudentDetails();
            base.OnInitialized();
        }

    }
}
