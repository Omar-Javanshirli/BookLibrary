using BookLibrary.Commands;
using BookLibrary.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BookLibrary.ViewModels
{
    public class LibraryHomeUCViewModel:BaseViewModel
    {
        public RelayCommand AddNewBookCommand { get; set; }
        public RelayCommand ShowAllBooksCommand { get; set; }
        public RelayCommand RegisterStudentCommand { get; set; }
        public RelayCommand SelectRentCommand { get; set; }
        public Grid MyGrid { get; internal set; }

        public LibraryHomeUCViewModel()
        {

            SelectRentCommand = new RelayCommand((e) =>
              {
                  App.MyGrid.Children.RemoveAt(0);

                  var viewModel = new RentUCViewModel();
                  var view = new RentUC();
                  view.DataContext = viewModel;

                  App.MyGrid.Children.Add(view);
              });


            AddNewBookCommand = new RelayCommand((e) =>
            {
                App.MyGrid.Children.RemoveAt(0);

                var viewModel=new AddBookUCViewModel();
                var view = new AddBookUC();
                view.DataContext = viewModel;

                App.MyGrid.Children.Add(view);
            });


            ShowAllBooksCommand = new RelayCommand((e) =>
              {
                  var view = new AllBooksUC();
                  var viewModel = new AllBooksViewModel();
                  view.DataContext = viewModel;

                  App.MyGrid.Children.RemoveAt(0);
                  App.MyGrid.Children.Add(view);
              });


            RegisterStudentCommand = new RelayCommand((e) =>
            {
                var viewModel = new RegisterStudentUCViewModel();
                var view = new RegisterStudentUC();
                view.DataContext=viewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(view);

            });
        }
    }
}
