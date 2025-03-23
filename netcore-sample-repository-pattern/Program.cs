using Microsoft.EntityFrameworkCore;
using netcore_sample_repository_pattern.DBContext;
using netcore_sample_repository_pattern.Impl;
using netcore_sample_repository_pattern.Interface;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

// Configure services
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("ProductDb"));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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


app.UseAuthorization();
app.MapControllers();

app.Run();
