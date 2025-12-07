// Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add CORS services to allow React to connect
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        // Must include the port your React app runs on (e.g., 5173 or 3000)
        policy.WithOrigins("http://localhost:5173", "http://localhost:3000") 
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Optionally remove swagger/swaggerUI lines if you don't use them
}

app.UseHttpsRedirection();

// IMPORTANT: Use the configured CORS policy before MapControllers
app.UseCors();

app.UseAuthorization();

app.MapControllers(); // Maps the routes defined in MissionController

app.Run();