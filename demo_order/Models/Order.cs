using System;
using System.Collections.Generic;

namespace demo_order.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public double OrderPrice
        public ICollection<Laptop> laptops { get; set; }
    }
}
