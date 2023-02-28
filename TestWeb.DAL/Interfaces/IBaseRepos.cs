using System.Collections.Generic;

namespace TestWeb.DAL.Interfaces
{
    public interface IBaseRepos<T>
    {
        bool Create(T entity);

        T Get(int id);

        IEnumerable<T> Select();

        bool Delete(T entity);


    }
}
