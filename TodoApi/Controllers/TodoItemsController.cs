using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private ITodoItemService _todoItemService;

        public TodoItemsController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        // GET: api/<TodoItemsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TodoItemsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todoItem = _todoItemService.GetById(id);
            return Ok(todoItem);
        }

        // POST api/<TodoItemsController>
        [HttpPost]
        public IActionResult Post([FromBody] TodoItem todoItem)
        {
            _todoItemService.Create(todoItem); 
            return Ok(new {message = "TodoItem created"});
        }

        // PUT api/<TodoItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
