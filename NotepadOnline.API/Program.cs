using NotepadOnline.API;
using NotepadOnline.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();