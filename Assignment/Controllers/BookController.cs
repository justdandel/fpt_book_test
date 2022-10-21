using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace Assignment.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;

        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Authorize(Roles ="StoreOwner")]
        public IActionResult Index()
        {
            var categories = context.categories.ToList();
            ViewBag.Categories = categories;
            return View(context.books.ToList());
        }
        
        [Route("/")]
        public IActionResult List()
        {
            var categories = context.categories.ToList();
            ViewBag.Categories = categories;
            return View(context.books.ToList());
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                //tao ra object student co id duoc yeu cau
                var book = context.books.Find(id);
                //xoa object co id vua tim thay
                context.books.Remove(book);
                // luu lai thay doi trong db
                context.SaveChanges();

                //gui thong bao ve trang index
                TempData["Message"] = "Deleted!";
                //khi dung redirect thi phai dung tempdata
                return RedirectToAction(nameof(Index));
            }
        }
        
        public IActionResult Detail(int id)
        {
            var authors = context.authors.ToList();
            ViewBag.Author = authors;
            var categories = context.categories.ToList();
            ViewBag.Categories = categories;
            var book = context.books.Include(s => s.Category).FirstOrDefault(s => s.Id == id);
            return View(book);
        }


        [HttpGet]
        public IActionResult Search(string name)
        {
            var categories = context.categories.ToList();
            ViewBag.Categories = categories;
            var book = context.books.Where(s => s.Name.Contains(name)).ToList();
            return View("List", book);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var author = context.authors.ToList();
            ViewBag.Author = author;
            var category = context.categories.ToList();
            ViewBag.Category = category;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                context.books.Add(book);
                context.SaveChanges();
                return Redirect("/");
            }
            var author = context.authors.ToList();
            ViewBag.Author = author;
            var categories = context.categories.ToList();
            ViewBag.Category = categories;
            return View();


        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var books = context.books.ToList();
            //du lieu day vao viewbag
            var author = context.authors.ToList();
            ViewBag.Author = author;
            var categories = context.categories.ToList();
            ViewBag.Category = categories;

            var c = books.FirstOrDefault(c => c.Id == id);

            return View(c);
        }

        [HttpPost]
        public IActionResult Edit(Book b)
        {
            if (ModelState.IsValid)
            {
                context.books.Update(b);
                context.SaveChanges();
                TempData["Message"] = "Edit successful!";
                return RedirectToAction("index");
            }
            else
            {
                var author = context.authors.ToList();
                ViewBag.Author = author;
                var categories = context.categories.ToList();
                ViewBag.Category = categories;
                return View();
            }
        }
    }
}
