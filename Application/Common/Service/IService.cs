using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Service
{
    //interface service générique
    public interface IService<T> where T : class
    {
        T Create(T entity);
        T Update(int id,T entity);
        T Delete(int id);
        T Get(int id);
        T GetAll();

    }
}
