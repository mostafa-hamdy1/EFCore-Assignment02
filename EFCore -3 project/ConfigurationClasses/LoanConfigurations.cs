using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_Assignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Assignment02.ConfigurationClasses
{
    public class LoanConfigurations : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            // Composite Primary Key
            builder.HasKey(l => new { l.BookId, l.BorrowerId });

            builder.HasOne(l => l.Book)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(l => l.BookId);

            builder.HasOne(l => l.Borrower)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(l => l.BorrowerId);
        }
    }
}
