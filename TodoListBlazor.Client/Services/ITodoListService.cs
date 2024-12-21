namespace TodoListBlazor.Client.Services;

public interface ITodoListService
{
    Task<IList<TodoListService>> GetTodoLists();
}
