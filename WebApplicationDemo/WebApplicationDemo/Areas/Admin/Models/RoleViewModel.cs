using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen rol adını giriniz.")]
        public string name { get; set; }
    }
}
