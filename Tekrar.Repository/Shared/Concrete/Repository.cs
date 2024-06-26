﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar.Data;
using Tekrar.Repository.Shared.Abstract;
using Tekrar.Repository.Shared.Concrete.config;

namespace Tekrar.Repository.Shared.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            string name = "terkar";
            name.lower();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
            return entity;

        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            Save();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
           return _dbSet.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
