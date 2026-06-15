using NotepadOnline.Application.Note;

namespace NotepadOnline.API;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(
        this IServiceCollection services)
    {
        services.AddScoped<INoteService, NoteService>();
        
        return services;
    }
}