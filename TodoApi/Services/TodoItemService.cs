using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoItemService : ITodoItemService
    {
        private DBContext _dbContext;

        public TodoItemService(DBContext context) {
            _dbContext = context;
        }

        public void Create(TodoItem item)
        {
            _dbContext.TodoItems.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(long id)
        {
            var todoItem = _dbContext.TodoItems.Find(id);
            if (todoItem == null)
            {
                throw new KeyNotFoundException("TodoItem not found");
            }
            return todoItem;
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
