using System.Text.Json.Serialization;

namespace Gazelle.Daemon 
{
  public static class Program 
  {
    public static void Main(string[] args) 
    { 
      Serve(args);
    }

    public static void Serve(string[] args) 
    {
      var builder = WebApplication.CreateSlimBuilder(args);
      var app = builder.Build();
      app.MapGet("/", () => "Hello, World!"); 
      app.Run();
    }
  }
}

// builder.Services.ConfigureHttpJsonOptions(options =>
// {
//     options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
// });

// var sampleTodos = new Todo[] {
//     new(1, "Walk the dog"),
//     new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
//     new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
//     new(4, "Clean the bathroom"),
//     new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
// };

// var todosApi = app.MapGroup("/todos");
// todosApi.MapGet("/", () => sampleTodos);
// todosApi.MapGet("/{id}", (int id) =>
//     sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
//         ? Results.Ok(todo)
//         : Results.NotFound());

// public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

// [JsonSerializable(typeof(Todo[]))]
// internal partial class AppJsonSerializerContext : JsonSerializerContext
// {

// }
