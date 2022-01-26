using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibarySystem.data
{
    [Table("Books")]
    public class Book
    {
        public int ID { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public int price { get; set; }
        [ForeignKey("category")]
        public int category_id { get; set; }
        public Category category { get; set; }
        [ForeignKey("author")]
        public int author_id { get; set; }
        public Author author { get; set; }
        public int stock { get; set; }
        public String path { get; set; }

    }
}
