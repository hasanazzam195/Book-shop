using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{
    public class AuthorService : IAuthor
    {
        LibaryContext context;
        public AuthorService(LibaryContext _context)
        {
            context = _context;
        }


        public void Insert(Author a)
        {
            context.authorContext.Add(a);
            context.SaveChanges();
        }

        public List<Author> data ()
        {
            List<Author> x = context.authorContext.ToList();
            return x;
        }

        public void Delete(int x)
        {
            Author author = context.authorContext.Find(x);
            context.authorContext.Remove(author);
            context.SaveChanges();
        }

    }
}
