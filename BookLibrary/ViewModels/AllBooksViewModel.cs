using BookLibrary.Helpers;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class AllBooksViewModel:BaseViewModel
    {
        private ObservableCollection<Book> allBooks;

        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }

        public AllBooksViewModel()
        {
            var booksFromFile = FileHelper.ReadBooks();
            AllBooks = new ObservableCollection<Book>(booksFromFile);
        }

    }
}
