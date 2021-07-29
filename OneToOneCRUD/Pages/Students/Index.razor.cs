using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using OneToOneCRUD.Entities;
using OneToOneCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Pages.Students
{
    public partial class Index
    {
        public List<Student> Students { get; set; } = new List<Student>();

        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager Navigator { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        protected override void OnInitialized()
        {
            Students = UnitOfWork.StudentRepo.GetStudents();
            base.OnInitialized();
        }

        private void OnDetailsClicked(int id)
        {
            var student=UnitOfWork.StudentRepo.GetStudentWithDetail(id);
            if (student.StudentDetails is null)
            {
                ModalParameters modalParamaters = new ModalParameters();
                modalParamaters.Add("StudentId", student.Id.ToString());
                Modal.Show<OneToOneCRUD.Pages.SDetails.Create>($"Create details of {student.Name}", modalParamaters);
            }
            else
            {
                Navigator.NavigateTo($"students/details/{id}");
            }
        }
    }
}
