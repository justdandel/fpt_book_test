using System.Collections.Generic;

namespace demo_order1.Models
{
    public class Laptopcs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
