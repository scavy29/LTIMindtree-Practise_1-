using Microsoft.EntityFrameworkCore;
using NewApiProject.Models;
using NewApiProject.Repositories;
using log4net;
using log4net.Config;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//Add Di
builder.Services.AddDbContext<ApplicationDbContext>(options=>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conStr"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IEmployeeRepository,EmployeeRepository>();

XmlConfigurator.Configure(new FileInfo("log4net.config"));
builder.Services.AddSingleton(LogManager.GetLogger(typeof(Program)));


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
