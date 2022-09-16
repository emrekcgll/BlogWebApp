using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Areas.Admin.Models;

namespace WebApplicationDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "teknoloji", categorycount = 10 });
            list.Add(new CategoryClass { categoryname = "yazılım", categorycount = 12 });
            list.Add(new CategoryClass { categoryname = "gündem", categorycount = 90 });
           
            return Json(new { jsonlist = list });

        }

    }
}
