using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.repository
{
    //interface repository générique 
    public interface IRepository <T> where T : class
    {
        Task<T> GetById(int id);
        IEnumerable<T> GetAll();

        Task<T> AddEntity(T entity);
        Task<T> UpdateEntity(int updtId,T entity);
        Task DeleteEntity(int id);
    }
}
