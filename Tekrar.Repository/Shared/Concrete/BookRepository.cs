using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar.Data;
using Tekrar.Models;
using Tekrar.Repository.Shared.Abstract;

namespace Tekrar.Repository.Shared.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public IQueryable<Book> Book()
        {
            return _context.Books;
        }
    }
}
