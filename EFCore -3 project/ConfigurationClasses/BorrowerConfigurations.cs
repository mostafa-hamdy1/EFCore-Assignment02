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
    public class BorrowerConfigurations : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name) 
                   .IsRequired() 
                   .HasMaxLength(100);
        }
    }
}
