using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibarySystem.data;

namespace LibarySystem.Controllers
{
    public class CategoryController : Controller
    {
        
        ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {

            categoryService = _categoryService;
        }
        public IActionResult Index(VMCategory vm)
        {
            List<Category> x = categoryService.returndata();
            vm.licategory = x;
            return View("CategorySec", vm);
        }

        public IActionResult SaveData(VMCategory vm)
        {
            categoryService.Insert(vm);
            List<Category> categories = categoryService.returndata();
            vm.licategory = categories;
            return View("CategorySec",vm);
        }

        public IActionResult DeleteData(int id,VMCategory vm)
        {
            categoryService.Delete(id);
            List<Category> x = categoryService.returndata();
            vm.licategory = x;
            return View("CategorySec",vm);
        }
    }
}
