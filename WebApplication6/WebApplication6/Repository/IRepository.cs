using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication6.Models;
using WebApplication6.TestData;

namespace WebApplication6.Repository
{
    public interface IRepository<T>
    {
        List<T> EntitiesList { get; set; }
        void Add(T entity);
        IEnumerable<T> Get();
        T GetById(int id);
        void Delete(T entity);
        void Update(T entity);
    }
}
