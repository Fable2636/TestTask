using TestTask.Services; // Импортируйте пространство имен вашего сервиса
using TestTask.Models; // Импортируйте пространство имен для ваших моделей (IFigure, Circle, Triangle)
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Добавление служб
builder.Services.AddControllers();

// Добавление Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настройка Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestTask API V1");
        c.RoutePrefix = string.Empty; // Устанавливает Swagger UI на корень приложения
    });
}

// Настройка конвейера обработки HTTP-запросов
app.MapControllers();

// Запуск приложения
app.Run();