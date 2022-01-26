using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{
    public interface ICategoryService
    {
        void Insert(VMCategory vm);
        List<Category> returndata();
        void Delete(int x);
    }
}
