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
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public bool StringDelete(string name)
        {
            Author author=_context.Authors.FirstOrDefault(a=>a.Name == name);
            base.Delete(author);
            return true;
        }
    }
}
