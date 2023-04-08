using Ex;
using Ex.Repositories;
using Ex.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddDbContext<Quiz>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddScoped<IAnswersRepository, AnswersRepository>();
builder.Services.AddScoped<IAnswersService, AnswersService>();

builder.Services.AddScoped<IStudentsRepository, StudentsRepository>();
builder.Services.AddScoped<IStudentsService, StudentsService>();

builder.Services.AddScoped<ITeachersRepository, TeachersRepository>();
builder.Services.AddScoped<ITeachersService, TeachersService>();

builder.Services.AddScoped<IDisciplinesRepository, DisciplinesRepository>();
builder.Services.AddScoped<IDisciplinesService, DisciplinesService>();

builder.Services.AddScoped<IStudentsDisciplinesRepository, StudentsDisciplinesRepository>();
builder.Services.AddScoped<IStudentsDisciplinesService, StudentsDisciplinesService>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nome do seu projeto", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nome do seu projeto v1");
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
