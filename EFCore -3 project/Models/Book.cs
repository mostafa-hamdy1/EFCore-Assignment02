using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment02.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Foreign Key & Navigation Property
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // Navigation Property (Many-To-Many Join)
        public List<Loan> Loans { get; set; }
    }
}
