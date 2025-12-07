// Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Backend.Models; // Required if you reference models directly here

var builder = WebApplication.CreateBuilder(args);

// --- 1. SERVICE CONFIGURATION ---
builder.Services.AddControllers();

// Configure Swagger for API documentation and testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure CORS to allow React frontend connection (e.g., ports 3000 and 5173)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://localhost:3000") 
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();

// --- 2. PIPELINE CONFIGURATION ---

// Enable Swagger UI only in Development environment
if (app.Environment.IsDevelopment())
{
    // These lines make Swagger available at http://localhost:5053/swagger/index.html
    app.UseSwagger();      
    app.UseSwaggerUI();    
}

// Comment out HttpsRedirection to prevent the "Failed to determine the https port" warning
// when running on HTTP (http://localhost:5053)
// app.UseHttpsRedirection(); 

// Use CORS before Authorization
app.UseCors();

app.UseAuthorization();

app.MapControllers(); 

app.Run();