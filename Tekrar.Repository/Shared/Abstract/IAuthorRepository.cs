using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar.Models;

namespace Tekrar.Repository.Shared.Abstract
{
    public interface IAuthorRepository:IRepository<Author>
    {
        bool StringDelete(string name);
    }
}
