using BookLibrary.Commands;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookLibrary.ViewModels
{
    public class AddBookUCViewModel:BaseViewModel
    {
        private Book book;

        public Book Book
        {
            get { return book; }
            set { book = value; OnPropertyChanged(); }
        }

        public RelayCommand AddBookCommand { get; set; }

        public AddBookUCViewModel()
        {
            Book=new Book();
            AddBookCommand = new RelayCommand((e) =>
              {
                  Book.Id = ++App.Global_ID;
                  App.BookRepo.AddBook(Book);
                  MessageBox.Show($"{Book.Title} book Added succesfully");
              });
        }

    }
}
