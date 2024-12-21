using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoListBlazor.Client.DataAccess;
using TodoListBlazor.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<ITodoListService, TodoListService>();

builder.Services.AddDbContext<AppDbContext>();

await builder.Build().RunAsync();
