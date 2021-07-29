using Microsoft.AspNetCore.Components;
using OneToOneCRUD.Entities;
using OneToOneCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Pages.Students
{
    public partial class Details
    {
        [Parameter]
        public string Id { get; set; }
        public Student Student { get; set; } = new Student();
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }

        protected override void OnParametersSet()
        {
            Student = UnitOfWork.StudentRepo.GetStudentWithDetail(int.Parse(Id));
            base.OnParametersSet();
        }
    }
}
