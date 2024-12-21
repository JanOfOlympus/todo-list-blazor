using TodoListBlazor.Client.DataAccess;
using TodoListBlazor.Client.Models;

namespace TodoListBlazor.Client.Services;

public class TodoListService : ITodoListService
{
    private readonly AppDbContext _context;

    public TodoListService(AppDbContext context)
    {
        _context = context;
    }

    public IList<TodoListModel> GetTodoLists()
    {
        return _context.TodoLists.ToList();
    }
}
