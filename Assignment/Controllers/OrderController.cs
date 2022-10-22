using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace Assignment.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext context;
        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Authorize(Roles = "Customer, StoreOwner")]
        public IActionResult Index()
        {
            var categories = context.categories.ToList();
            ViewBag.Categories = categories;
            var books = context.books.ToList();
            ViewBag.Book = books;
            var orders = context.orders.ToList();
            return View(orders);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult MakeOrder(int book, int quantity)
        {
            var categories = context.categories.ToList();
            ViewBag.Categories = categories;
            var books = context.books.Find(book);
            var order = new Order();
            order.Book = books;
            order.OrderQuantity = quantity;
            order.BookID = book;
            order.OrderDate = System.DateTime.Now;
            order.OrderPrice = books.Price * quantity;
            order.UserEmail = User.Identity.Name;
            books.Quantity -= quantity;
            context.orders.Add(order);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
