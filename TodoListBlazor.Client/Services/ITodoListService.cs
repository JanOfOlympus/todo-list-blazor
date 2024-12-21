using TodoListBlazor.Client.Models;

namespace TodoListBlazor.Client.Services;

public interface ITodoListService
{
    Task<IList<TodoItemModel>> GetTodoItemsAsync();

    Task AddTodoItem(TodoItemModel todoList);

    Task UpdateTodoItem(TodoItemModel todoItem);
}
