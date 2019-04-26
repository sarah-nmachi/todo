using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Services;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        private readonly  ITodoitemService _todoitemService;
            public TodoController(ITodoitemService todoitemService)
        {
            _todoitemService = todoitemService;
        }

        [ActionName("index")]
        public async Task<IActionResult> IndexAsync()
        {
            // GET TO DO ITEM FROM DATABASE
            var Items = await _todoitemService.GetIncompleteItemsAsync();
            
            //  PUT ITEMS IN A MODEL
            var model = new TodoViewModel()
            {
                Items = Items
            };
            // PASS THE VIEW TO MODEL AND RENDER
            return View(model);
        }
    }
}