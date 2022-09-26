using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Library
    {
        public List<Student> Students { get; set; }
        public List<Librarian> Librarians { get; set; }
        public List<Book> Books { get; set; }
        public decimal TotalBudget { get; set; }
    }
}
