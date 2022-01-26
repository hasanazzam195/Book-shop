using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibarySystem.data
{
    [Table("Authors")]
    public class Author
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        [ForeignKey("nutionality")]
        public int Nutionality_id { get; set; }
        public Nutionality nutionality { get; set; }
        public string path { get; set; }
        public List<Book> libook { get; set; }

    }
}
