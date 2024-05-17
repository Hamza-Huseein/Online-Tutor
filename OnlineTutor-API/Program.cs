using Microsoft.EntityFrameworkCore;
using OnlineTutor_Core.Context;
using OnlineTutor_Core.IRepos;
using OnlineTutor_Core.IServices;
using OnlineTutor_Infr.Repos;
using OnlineTutor_Infr.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<OnlineTutorDBContext>(cnn => cnn.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnect")));
builder.Services.AddDbContext<OnlineTutorDBContext>(option => option.UseMySQL(builder.Configuration.GetConnectionString("mysqlconnect")));
builder.Services.AddScoped<IMainServices, MainServices>();
builder.Services.AddScoped<IMainRepos, MainRepos>();

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
