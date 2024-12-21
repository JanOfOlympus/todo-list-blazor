using Microsoft.EntityFrameworkCore;
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

    public async Task AddTodoItem(TodoItemModel todoList)
    {
        _context.TodoItems.Add(todoList);
        await _context.SaveChangesAsync();
    }

    public async Task<IList<TodoItemModel>> GetTodoItemsAsync()
    {
        return await _context.TodoItems.ToListAsync();
    }

    public async Task UpdateTodoItem(TodoItemModel todoItem)
    {
        _context.TodoItems.Update(todoItem);
        await _context.SaveChangesAsync();
    }
}
