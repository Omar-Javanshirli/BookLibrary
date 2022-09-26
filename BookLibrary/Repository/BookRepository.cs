using BookLibrary.Helpers;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepository
    {
        public List<Book> Books { get; set; }
        public BookRepository()
        {
            if (!File.Exists("books.json"))
            {
                Books = new List<Book>
            {
                new Book
                {
                    Title="Crime and Punishment",
                     Discount=10,
                      Id=++App.Global_ID,
                       Page=750,
                        Price=17.75,
                         BookCount=10
                }
            };
                FileHelper.WriteBooks(Books);
            }
            else
            {
                Books = FileHelper.ReadBooks();
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            FileHelper.WriteBooks(Books);
        }
    }
}
