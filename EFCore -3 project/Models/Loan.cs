using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment02.Models
{
    public class Loan
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }

        public DateTime LoanDate { get; set; }
    }
}
