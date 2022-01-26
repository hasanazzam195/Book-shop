using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{
    public interface IAuthor
    {
        List<Author> data();
        void Insert(Author a);
        void Delete(int x);
    }
}
