using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddIdentityServices(builder.Configuration);

    
var app = builder.Build();

app.UseCors(policy => {
    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200","https://localhost:4200");
});

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
