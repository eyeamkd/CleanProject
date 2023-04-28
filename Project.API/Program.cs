using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Project.Application;
using Project.Domain;
using Project.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configurationManager = builder.Configuration;
var connectionString = configurationManager.GetConnectionString("DefaultConnection");
var migrationAssembly = configurationManager
                        .GetSection("Constants")
                        .GetSection("MigrationAssembly").Value;

// Add services to the container.
builder.Services.AddDbContext<ProjectDBContext>();
builder.Services.AddScoped<IEntityService, EntityService>();
builder.Services.AddScoped<IEntityRepository, EntityRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Project API",
        Description = "Project API Description",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
