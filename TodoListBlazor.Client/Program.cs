using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using TodoListBlazor.Client.DataAccess;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

await builder.Build().RunAsync();
