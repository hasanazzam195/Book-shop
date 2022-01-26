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
    public class BookController : Controller
    {
        ICategoryService categoryService;
        IAuthor author;
        IBookService BookService;
        VMBook vm;
        IConfiguration configuration;

        public BookController(ICategoryService _categoryService,IAuthor _author, IBookService _BookService, IConfiguration _configuration)
        {
            categoryService = _categoryService;
            author = _author;
            BookService = _BookService;
            vm = new VMBook();
            configuration = _configuration;
        }
        public IActionResult Index()
         {
            vm.liBook= BookService.returnData();
            vm.liauthor = author.data();
            vm.licategory = categoryService.returndata();

            return View("BookSec",vm);
        }

        public IActionResult SaveData(VMBook vm)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\" + configuration["filePath"], vm.ProfileImage.FileName);
            vm.ProfileImage.CopyTo(new FileStream(filePath, FileMode.Create));
            vm.book.path = "http://localhost/LibarySystem//" + configuration["filePath"] + "/" + vm.ProfileImage.FileName;
            BookService.Insert(vm.book);
            List<Category> x = categoryService.returndata();
            List<Author> a = author.data();
            List<Book> b = BookService.returnData();
            vm.liBook = b;
            vm.licategory = x;
            vm.liauthor = a;
            return View("BookSec",vm);
        }

        public IActionResult DeleteData(VMBook vm,int id)
        {
            BookService.Delete(id);
            vm.liBook = BookService.returnData();
            vm.liauthor = author.data();
            vm.licategory = categoryService.returndata();
            return View("BookSec", vm);
        }


    }
}
