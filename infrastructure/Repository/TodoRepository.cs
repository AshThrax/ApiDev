using Application.Common.Repository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TodoRepository : IToDoRepository
    {
        public Task<ToDoItem> AddEntity(ToDoItem entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoItem> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoItem> UpdateEntity(int updtId, ToDoItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
