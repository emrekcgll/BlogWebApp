using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adını girin.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Şifreyi girin.")]
        public string password { get; set; }
    }
}
