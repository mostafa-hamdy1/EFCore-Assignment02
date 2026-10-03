using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Foreign Key & Navigation Property (Many-To-One)
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation Property (Many-To-Many)
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
