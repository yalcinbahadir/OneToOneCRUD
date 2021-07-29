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
    public partial class Create
    {
        public StudentModel Model { get; set; } = new StudentModel();
        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }
        [Inject]
        public NavigationManager Navigator { get; set; }
        private void HandelValidSubmit()
        {
            UnitOfWork.StudentRepo.AddStudent(new Student { Name = Model.Name });
            Navigator.NavigateTo("students/index");
        }
    }
}
