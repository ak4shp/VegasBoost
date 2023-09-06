// For dependecy injection and configuration 
var builder = WebApplication.CreateBuilder(args);

{
    // Add services to the container.
    builder.Services.AddControllers();
} 

// Manage Request Pipeline
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}