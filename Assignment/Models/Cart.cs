using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public int OrderPrice { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
