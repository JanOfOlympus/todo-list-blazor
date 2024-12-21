using TodoListBlazor.Client.Models;

namespace TodoListBlazor.Client.Services;

public interface ITodoListService
{
    IList<TodoListModel> GetTodoLists();
}
