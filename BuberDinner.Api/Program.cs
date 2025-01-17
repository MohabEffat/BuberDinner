using Microsoft.AspNetCore.Identity;
using System.Text;

namespace SohatNotebook.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            {
                builder.Services.AddControllers();
            }
            var app = builder.Build();
            {
                app.UseHttpsRedirection();

                app.MapControllers();

                app.Run();
            }

        }
    }
}
