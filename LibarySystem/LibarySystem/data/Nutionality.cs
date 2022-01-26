using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibarySystem.data
{
    [Table("Nutionalities")]
    public class Nutionality
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Author> authors { get; set; }
    }
}
