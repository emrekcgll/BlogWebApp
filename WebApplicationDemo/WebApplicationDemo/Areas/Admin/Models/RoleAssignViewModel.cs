using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int roleId { get; set; }
        public string name { get; set; }
        public bool exists { get; set; }
    }
}
