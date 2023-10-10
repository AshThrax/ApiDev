using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<ToDoItem> ToDoItems { get; }
        DbSet<ListTodoItem> ListTodoItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
