using AutoMapper;
using HouseRent_API;
using HouseRent_API.Data;
using HouseRent_API.Repository;
using HouseRent_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IPublicationRepository, PublicationRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));

// Add services to the container.

Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("log/publications.txt", rollingInterval: RollingInterval.Day).CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddControllers().AddNewtonsoftJson();
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
