﻿using BookLibrary.Commands;
using BookLibrary.Helpers;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookLibrary.ViewModels
{
    public class RentUCViewModel:BaseViewModel
    {

        private Book selectedBook;

        public Book SelectedBook
        {
            get { return selectedBook; }
            set { selectedBook = value; OnPropertyChanged(); }
        }

        private Student selectedStudent;

        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set { selectedStudent = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Student> students;

        public ObservableCollection<Student> AllStudents
        {
            get { return students; }
            set { students = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Book> books;

        public ObservableCollection<Book> AllBooks
        {
            get { return books; }
            set { books = value; OnPropertyChanged(); }
        }

        private Rent rent;

        public Rent Rent
        {
            get { return rent; }
            set { rent = value; OnPropertyChanged(); }
        }
        public RelayCommand CalculateCommand { get; set; }
        public RelayCommand RentCommand { get; set; }


        public RentUCViewModel()
        {
            Rent = new Rent();
            SelectedBook = new Book();
            SelectedStudent = new Student();

            Rent.RentDate = DateTime.Now;

            AllStudents = new ObservableCollection<Student>(FileHelper.ReadStudents());
            AllBooks = new ObservableCollection<Book>(FileHelper.ReadBooks());

            CalculateCommand = new RelayCommand((e) =>
              {
                  var total = Rent.Amount* SelectedBook.Price * Rent.RentDays;
                  Rent.TotalPayment = (decimal)total;
                  var rent = Rent;
                  Rent = rent;
              });

            RentCommand = new RelayCommand((e) =>
              {

            Rent.Book = SelectedBook;
            SelectedStudent.Rents.Add(Rent);
                  FileHelper.WriteStudents(AllStudents.ToList());
                  MessageBox.Show($"{Rent.Book.Title} rented successfully");
              });
        }

    }
}
