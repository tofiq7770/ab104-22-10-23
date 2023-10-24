using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_22_10_23
{
    internal class Library:BaseEntity
    {
        private static int _id = 1;
        public List<Book> _books = new List<Book>();

        public Library(string name)
        {
            Id = _id++;
            Name = name;
        }
        public void AddBook(Book book)
        {
            _books.Add(book);

        }
        public void ListBooks()
        {
            foreach (Book item in _books)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Author + " " + item.Category.Name);
            }

        }


    }
}
