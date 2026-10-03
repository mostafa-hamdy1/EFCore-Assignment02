using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment02.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        // Foreign Key & Navigation Property
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Navigation Property (Many-To-Many Join)
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
