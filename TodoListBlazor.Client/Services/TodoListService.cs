using TodoListBlazor.Client.DataAccess;

namespace TodoListBlazor.Client.Services;

public class TodoListService : ITodoListService
{
    private readonly AppDbContext _context;

    public TodoListService(AppDbContext context)
    {
        _context = context;
    }

    public Task<IList<TodoListService>> GetTodoLists()
    {
        throw new NotImplementedException();
    }
}
