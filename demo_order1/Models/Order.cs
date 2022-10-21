using System.Collections.Generic;
using System;

namespace demo_order1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public double OrderPrice { get; set; }
        public int LaptopId     { get; set; }
        public Laptopcs Laptopcs { get; set; }
    }
}
