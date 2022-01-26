using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{
    public class CategoryService : ICategoryService
    {
        LibaryContext context;
        public CategoryService(LibaryContext _context)
        {
            context = _context;
        }
        public void Insert(VMCategory vm)
        {
            context.categoryContext.Add(vm.category);
            context.SaveChanges();
        }

        public List<Category>  ()
        {
            List<Category> liCategory = context.categoryContext.ToList();
            return liCategory;
        }

        public void Delete(int x)
        {
            Category category = context.categoryContext.Find(x);
            context.categoryContext.Remove(category);
            context.SaveChanges();
        }


    }
}
