using System.Net;

namespace RoutingProj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
                       
            app.MapGet("/api/people", async context =>
                await context.Response.WriteAsJsonAsync(Person.All));

            app.MapGet("/api/person/{name}", async (HttpContext context, string name) =>
            {
                Person p = Person.All.Where(p => p.Name == name).FirstOrDefault();
                if (p != null)
                {
                    await context.Response.WriteAsJsonAsync(p);
                }
                else
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            });

            app.MapGet("/api/person/{id:int}", async (HttpContext context, int id) =>
            {
                Person p = Person.All.Where(p => p.Id == id).FirstOrDefault();
                if (p != null)
                {
                    await context.Response.WriteAsJsonAsync(p);
                }
                else
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            });

            app.Run();
        }
    }
}
