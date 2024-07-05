using Microsoft.EntityFrameworkCore;
using FirstAPI.Models;
using Microsoft.Extensions.DependencyInjection;
using FirstAPI.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FirstAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FirstAPIContext") ?? throw new InvalidOperationException("Connection string 'FirstAPIContext' not found.")));

builder.Services.AddControllers();
builder.Services.AddDbContext<CarsContext>(opt =>
    opt.UseInMemoryDatabase("Cars"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();