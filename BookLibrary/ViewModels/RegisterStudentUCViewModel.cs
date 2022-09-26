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
    public class RegisterStudentUCViewModel:BaseViewModel
    {
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value;OnPropertyChanged(); }
        }

        public RelayCommand AddStudentCommand { get; set; }
        public RegisterStudentUCViewModel()
        {
            Student=new Student();
            AddStudentCommand = new RelayCommand((e) =>
              {
                  this.Student.Id = ++App.Global_ID;
                  App.StudentRepo.AddStudent(Student);
                  MessageBox.Show($"{Student.Fullname} added successfully\n" +
                      $"Your pass : {Student.Password}");
              });
        }

    }
}
