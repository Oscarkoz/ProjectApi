using Microsoft.EntityFrameworkCore;
using ProjectAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Registrera DbContext som använder minnesdatabas
builder.Services.AddDbContext<ProjectContext>(opt =>
    opt.UseInMemoryDatabase("ProjectList"));

// ✅ Lägg till CORS-policy
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000") // React-projektets ursprung
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Seeda exempeldata
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ProjectContext>();
    SeedData.Initialize(context);
}

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// ✅ Aktivera CORS innan controllers
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
