using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibarySystem.data
{
    public class LibaryContext : DbContext
    {
        IConfiguration configuration;
        public LibaryContext()
        {

        }
        public LibaryContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        
        public DbSet<Author> authorContext { get; set; }
        public DbSet<Category> categoryContext { get; set; }
        public DbSet<Book> BookContext { get; set; }
        public DbSet<Nutionality> nutionalityContext { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("LibaryConnectionStr"));
            //optionsBuilder.UseSqlServer("data source = localhost; initial catalog = LibarySysDb; Integrated security = true");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
