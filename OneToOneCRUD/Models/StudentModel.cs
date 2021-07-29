using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneToOneCRUD.Models
{
    public class StudentModel
    {
        [Required]
        public string Name { get; set; }
    }
}
