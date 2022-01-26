using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{
    public class BookService : IBookService
    {
        LibaryContext context;
        public BookService(LibaryContext _context)
        {
            context = _context;
        }


        public List<Book> returnData()
        {
            List<Book> li = context.BookContext.ToList();
            return li;
        }
        public void Insert(Book b)
        {
            context.BookContext.Add(b);
            context.SaveChanges();
        }

        public void Delete(int x)
        {
            Book book = context.BookContext.Find(x);
            context.BookContext.Remove(book);
            context.SaveChanges();
        }
    }
}
