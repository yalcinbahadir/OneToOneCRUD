using Microsoft.AspNetCore.Components;
using OneToOneCRUD.Entities;
using OneToOneCRUD.Models;
using OneToOneCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Pages.Students
{
    public partial class CreateWithDetails
    {
        public StudentWithDetailsModel Model { get; set; } = new StudentWithDetailsModel();
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager Navigator { get; set; }
        private void HandelValidSubmit()
        {
            var student = new Student
            {
                Name = Model.Name,
                StudentDetails = new StudentDetails
                {
                    Address = Model.Address,
                    Email = Model.Email
                }
            };

            UnitOfWork.StudentRepo.AddStudent(student);
            Navigator.NavigateTo("students/index");
        }
    }
}
