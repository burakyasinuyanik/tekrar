using Microsoft.AspNetCore.Mvc;
using Tekrar.Repository.Shared.Abstract;

namespace tekrar.web.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IActionResult Index()
        {
          authorRepository.
            return View();

        }
        public IActionResult StringDelete(string name)
        {
            authorRepository.StringDelete(name);
            return Ok();
        }
    
    }
}
