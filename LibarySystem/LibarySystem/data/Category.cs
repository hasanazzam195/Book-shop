using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibarySystem.data
{
    [Table("Categories")]
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Book> libook { get; set; }
        
    }
}
