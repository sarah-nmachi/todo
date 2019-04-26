using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Data;
using Todo.Models;

namespace Todo.Services
{
    public class TodoItemService : ITodoitemService
    {
        private readonly ApplicationDbContext _context;
        public  TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            return await _context.Items
                .Where(x => x.IsDone == false)
                .ToArrayAsync();
        }

        Task<TodoItemService[]> ITodoitemService.GetIncompleteItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
