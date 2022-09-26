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
    public class HomeUCViewModel:BaseViewModel
    {
        public RelayCommand SelectLibrarianCommand { get; set; }
        public RelayCommand SelectStudentCommand { get; set; }
        public HomeUCViewModel()
        {
            SelectLibrarianCommand = new RelayCommand((e) =>
              {
                  App.BackPage = App.MyGrid.Children[0];
                  App.MyGrid.Children.RemoveAt(0);

                  var uc = new LibrarianUC();
                  var viewModel = new LibrarianUCViewModel();
                  viewModel.Username = "admin";
                  viewModel.Password = "admin"; 

                  uc.DataContext = viewModel;

                  App.MyGrid.Children.Add(uc);
              });
        }
    }
}
