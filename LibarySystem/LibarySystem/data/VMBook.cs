using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace LibarySystem.data
{
    public class VMBook
    {
        public Book book { get; set; }
        public List<Book> liBook { get; set; }
        public List<Category> licategory { get; set; }
        public List<Author> liauthor { get; set; }
        public IFormFile ProfileImage { get; set; }

    }
}
