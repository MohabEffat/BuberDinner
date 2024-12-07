using BubberDinner.Application.Services;
using BubberDinner.Infrastructure;
namespace SohatNotebook.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Add services to the container.
            {
                builder.Services.AddControllers();

                builder.Services
                    .AddApplication()
                    .AddInfrastructure();
            }

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            {
                app.UseHttpsRedirection();

                app.UseAuthentication();

                app.UseAuthorization();

                app.MapControllers();

                app.Run();
            }

        }
    }
}
