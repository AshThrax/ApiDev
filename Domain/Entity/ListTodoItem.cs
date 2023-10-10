using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ListTodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IList<ToDoItem> Items;
      
    }
}
