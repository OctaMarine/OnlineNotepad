using Microsoft.EntityFrameworkCore;
using NotepadOnline.Infrastructure.Note.Repositories;
using NotepadOnline.Repository;

namespace NotepadOnline.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PostgresConnection");
        
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString, npgsqlOptions =>
            {
                npgsqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                npgsqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorCodesToAdd: null);
            }));
        
        services.AddScoped<INoteRepository, NoteRepository>();
        
        return services;
    }
}