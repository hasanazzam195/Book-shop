using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibarySystem.data;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace LibarySystem.Controllers
{
    public class AuthorsController : Controller
    {
        IAuthor authorservice;
        IConfiguration configuration;
        INutionalityService nutionalityService;
        public AuthorsController(IAuthor _authorService,IConfiguration _configuration,INutionalityService _nutionalityService)
        {
            authorservice = _authorService;
            configuration = _configuration;
            nutionalityService = _nutionalityService;
        }
        public IActionResult Index(VMAuthor vm)
        {
            List<Nutionality> _linutionality = nutionalityService.loadAllNution();
            List<Author> _liauthors = authorservice.data();
            vm.linutionality = _linutionality;
            vm.liAuthor = _liauthors;
            return View("AuthorSec",vm);
        }

        public IActionResult SaveData(VMAuthor vm)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\" + configuration["filePath"], vm.ProfileImage.FileName);
            vm.ProfileImage.CopyTo(new FileStream(filePath, FileMode.Create));
            vm.author.path = "http://localhost/LibarySystem//" + configuration["filePath"] + "/" + vm.ProfileImage.FileName;
            authorservice.Insert(vm.author);
            List<Nutionality> _linutionality = nutionalityService.loadAllNution();
            List<Author> liauthors = authorservice.data();
            vm.liAuthor = liauthors;
            vm.linutionality = _linutionality;
            return View("AuthorSec",vm);
        }

        public IActionResult DeleteData(int id,VMAuthor vm)
        {
            authorservice.Delete(id);
            List<Nutionality> _linutionality = nutionalityService.loadAllNution();
            List<Author> _liauthors = authorservice.data();
            vm.linutionality = _linutionality;
            vm.liAuthor = _liauthors;
            return View("AuthorSec", vm);
        }
    }
}
