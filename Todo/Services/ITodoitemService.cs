using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Services
{
    public interface ITodoitemService
    {
        Task<TodoItemService[]> GetIncompleteItemsAsync();
    }
}
