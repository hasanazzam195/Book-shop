using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{
    public interface IBookService
    {
        List<Book> returnData();
        public void Insert(Book b);
        void Delete(int x);
    }
}
