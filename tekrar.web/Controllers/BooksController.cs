using Microsoft.AspNetCore.Mvc;
using Tekrar.Models;
using Tekrar.Repository.Shared.Concrete;

namespace tekrar.web.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookRepository bookRepository;

        public BooksController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            bookRepository.
           
            return View(bookRepository.Book);
        }

        public IActionResult Add(Book book)
        {
            bookRepository.Add(book);

            return Ok(book);
        }
    }
}
