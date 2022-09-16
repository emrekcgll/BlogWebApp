using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Areas.Admin.Models;

namespace WebApplicationDemo.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                id=1,
                name="Nazlı"
            },
            new WriterClass
            {
                id=2,
                name="Beyza"
            },
            new WriterClass
            {
                id=3,
                name="Küpra"
            }
        };
    }
}
