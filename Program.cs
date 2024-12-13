using Microsoft.EntityFrameworkCore;

namespace AzureProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

        var app = builder.Build();
    }
}
