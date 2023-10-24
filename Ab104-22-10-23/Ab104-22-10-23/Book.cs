using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_22_10_23
{
    internal class Book:BaseEntity
    {
        private static int _id = 0;

        public string Author { get; set; }
        public Category Category { get; set; }

        public Book(string name,string author,Category category)
        {
            Id = ++_id;
            Name = name;
            Author = author;
            Category = category;
        }
    }
}
