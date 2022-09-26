using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookLibrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static int Global_ID = 0;
        public static BookRepository BookRepo;
        public static StudentRepository StudentRepo;
        public static Grid MyGrid;
        public static UIElement BackPage;
        public App()
        {
            BookRepo = new BookRepository();
            StudentRepo=new StudentRepository();
        }
    }
}
