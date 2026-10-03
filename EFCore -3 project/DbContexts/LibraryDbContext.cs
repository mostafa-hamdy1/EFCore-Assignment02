using Microsoft.EntityFrameworkCore;
using EFCore_Assignment02.Models;
using EFCore_Assignment02.ConfigurationClasses;

namespace EFCore_Assignment02.DbContexts
{
    public class LibraryDbContext : DbContext
    {
        //part02
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LibraryDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //part02
            modelBuilder.ApplyConfiguration(new AuthorConfigurations());
            modelBuilder.ApplyConfiguration(new BookConfigurations());
            modelBuilder.ApplyConfiguration(new BorrowerConfigurations());
            modelBuilder.ApplyConfiguration(new LoanConfigurations());
        }
    }
}