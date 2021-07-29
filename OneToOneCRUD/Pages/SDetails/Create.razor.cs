using Microsoft.AspNetCore.Components;
using OneToOneCRUD.Entities;
using OneToOneCRUD.Models;
using OneToOneCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Pages.SDetails
{
    public partial class Create
    {
        public StudentDetailsModel Model { get; set; } = new StudentDetailsModel();
        [Parameter]
        public string StudentId { get; set; } = "-1";
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager Navigator { get; set; }
        protected override void OnInitialized()
        {
            Model.Students = UnitOfWork.StudentRepo.GetStudents().Where(s=>s.StudentDetails==null).ToList();
            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {
            Model.StudentId = StudentId;
            Model.Students = UnitOfWork.StudentRepo.GetStudentsWithDetails().Where(s => s.StudentDetails == null).ToList();
            base.OnParametersSet();
        }
        private void HandelValidSubmit()
        {
            var detail = new StudentDetails {
                 Address= Model.Address,
                 Email=Model.Email, 
                 StudentId=int.Parse(Model.StudentId)
            };
            UnitOfWork.StudStudentDetailsRepo.AddStudentDetails(detail);
            Navigator.NavigateTo("sdetails/index");
        }
    }
}
