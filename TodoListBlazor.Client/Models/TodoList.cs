﻿namespace TodoListBlazor.Client.Models;

public class TodoList
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public string Status { get; set; } = "";
}