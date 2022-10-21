using System.ComponentModel.DataAnnotations;
using System;

namespace Assignment.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public double OrderPrice { get; set; }
        public int OrderQuantity { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
