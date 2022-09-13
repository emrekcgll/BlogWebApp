using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]//Sayfa yüklenince çalışır
        public IActionResult Index()
        {

            return View();

        }
        [HttpPost]//Sayfadaki buton tetiklenince parametre olmadan çalışmaz
        public IActionResult Index(Writer p)
        {
            WriterValidator wr = new WriterValidator();
            ValidationResult result = wr.Validate(p);
            if (result.IsValid)
            {
                p.WriterImage = "https://resimyükle.com/y/a1c61..jpg";
                p.WriterStatus = true;
                p.WriterAbout = "Üye";
                wm.TAdd(p);
                return RedirectToAction("Index", "Blog"); //Index action a git. Index action blogun içinde
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
    }
}
