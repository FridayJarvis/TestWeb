using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeb.Domain.Models;

namespace TestWeb.DAL.Interfaces
{
    public interface IPizzaRepos : IBaseRepos<Pizza>
    {
        Pizza GetByName(string name);
        Task<IEnumerable<Pizza>> Select();
    }
}
