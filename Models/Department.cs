using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Department
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }

    }
}
