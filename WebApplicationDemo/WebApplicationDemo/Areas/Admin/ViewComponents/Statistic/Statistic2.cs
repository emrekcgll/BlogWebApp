using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v2 = c.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogContent).Take(1).FirstOrDefault().Substring(0,80);
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
