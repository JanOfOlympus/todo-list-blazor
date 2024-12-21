using TodoListBlazor.Client.Enums;

namespace TodoListBlazor.Client.Models;

public class TodoItemModel
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public TodoItemState State { get; set; } = TodoItemState.Pending;
}
