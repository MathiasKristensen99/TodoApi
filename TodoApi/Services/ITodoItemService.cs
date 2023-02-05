using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoItemService
    {
        TodoItem GetById(long id);
        void Update(TodoItem item);
        void Delete(long id);
        void Create(TodoItem item);
    }
}
