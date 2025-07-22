using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        // GET: ExamController
        public ActionResult Index()
        {
            var author1 = new Author
            {
                Id = 1,
                FirstName = "J.R.R.",
                LastName = "Tolkien",
                DateOfBirth = new DateTime(1892, 1, 3)
            };
            var author2 = new Author
            {
                Id = 2,
                FirstName = "Richard A.",
                LastName = "Knaak",
                DateOfBirth = new DateTime(1961, 5, 28)
            };
            var author3 = new Author
            {
                Id = 3,
                FirstName = "J.D.",
                LastName = "Salinger",
                DateOfBirth = new DateTime(1919, 1, 1)
            };

            var books = new List<Book>
            {
                new Book { Id = 1, Title = "The Lord of the Rings", YearPublished = 1954, Author = author1 },
                new Book { Id = 2, Title = "The Hobbit", YearPublished = 1937, Author = author1 },
                new Book { Id = 3, Title = "Diablo: Legacy of Blood", YearPublished = 2001, Author = author2 },
                new Book { Id = 4, Title = "Diablo: The Kingdom of Shadow", YearPublished = 2002, Author = author2 },
                new Book { Id = 5, Title = "The Catcher in the Rye", YearPublished = 1951, Author = author3 },
            };

            return View("Exam", books);
        }
    }
}
