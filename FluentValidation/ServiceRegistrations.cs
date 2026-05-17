using FluentValidation.Data;
using Microsoft.EntityFrameworkCore;

namespace FluentValidation
{
    public static class ServiceRegistrations
    {
        public static void AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(services.BuildServiceProvider().GetRequiredService<IConfiguration>().GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'AppDbContext' not found.")));
            // Register your services here
            // For example:
            // services.AddScoped<IMyService, MyService>();
        }
    }
}
