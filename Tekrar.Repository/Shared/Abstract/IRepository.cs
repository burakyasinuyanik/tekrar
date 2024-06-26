using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar.Repository.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
        void Save();
    }
}
