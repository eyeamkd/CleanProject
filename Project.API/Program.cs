using Microsoft.EntityFrameworkCore;
using Project.Domain;
using Project.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configurationManager = builder.Configuration;
var connectionString = configurationManager.GetConnectionString("DefaultConnection");
var migrationAssembly = configurationManager
                        .GetSection("Constants")
                        .GetSection("MigrationAssembly").Value;

// Add services to the container.
builder.Services.AddDbContext<ProjectDBContext>(options => options.UseSqlite(connectionString));

var dbContextOptionsBuilder = new DbContextOptionsBuilder<ProjectDBContext>();
dbContextOptionsBuilder.UseSqlite(migrationAssembly);

builder.Services.AddDbContext<ProjectDBContext>(
    options => options.UseSqlite(connectionString, 
    b => b.MigrationsAssembly("Project.API")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
