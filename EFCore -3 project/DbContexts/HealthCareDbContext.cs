using Microsoft.EntityFrameworkCore;
using EFCore_Assignment02.Models;
using EFCore_Assignment02.ConfigurationClasses;

namespace EFCore_Assignment02.DbContexts
{
    public class HealthCareDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=HealthCareDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppointmentConfigurations());
        }
    }
}