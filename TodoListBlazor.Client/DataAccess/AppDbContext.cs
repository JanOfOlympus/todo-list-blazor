using Microsoft.EntityFrameworkCore;
using TodoListBlazor.Client.Models;

namespace TodoListBlazor.Client.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<TodoListModel> TodoLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=todo.db");
        }
    }
}
