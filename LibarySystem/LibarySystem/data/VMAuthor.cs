using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace LibarySystem.data
{
    public class VMAuthor
    {
        public Author author { get; set; }
        public List<Author> liAuthor { get; set; }
        public List<Nutionality> linutionality { get; set; }
        public IFormFile ProfileImage { get; set; }

    }
}
