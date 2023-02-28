using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeb.DAL.Interfaces;
using TestWeb.Domain.Models;

namespace TestWeb.DAL.Repositories
{
    public class PizzaRepos : IPizzaRepos
    {
        private readonly AppDbContext _db;

        public PizzaRepos(AppDbContext db)
        {
            _db = db;
        }

        public bool Create(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public Pizza Get(int id)
        {
            throw new NotImplementedException();
        }

        public Pizza GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pizza>> Select()
        {
            return await _db.Pizza.ToListAsync();
        }

        IEnumerable<Pizza> IBaseRepos<Pizza>.Select()
        {
            throw new System.NotImplementedException();
        }
    }
}

