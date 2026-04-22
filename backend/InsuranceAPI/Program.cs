using Microsoft.EntityFrameworkCore;
using InsuranceAPI;

var builder = WebApplication.CreateBuilder(args);  //

builder.Services.AddControllers(); // Add services to the container.
builder.Services.AddEndpointsApiExplorer(); // Add services for API documentation.
builder.Services.AddSwaggerGen(); // Add services for Swagger UI.   

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 

var app = builder.Build(); // Build the application.

if (app.Environment.IsDevelopment())  // Check if the application is running in the development environment.
{
    app.UseSwagger(); // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwaggerUI(); // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
}

app.UseHttpsRedirection(); // Enable middleware to redirect HTTP requests to HTTPS.

app.UseAuthorization(); // Enable middleware to authorize users. This should be placed between UseAuthentication and UseEndpoints.

app.MapControllers();  // Map controller routes. This will route incoming HTTP requests to the appropriate controller actions based on the defined routes.

app.Run(); // Run the application.