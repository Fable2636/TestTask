using TestTask.Services; // ������������ ������������ ���� ������ �������
using TestTask.Models; // ������������ ������������ ���� ��� ����� ������� (IFigure, Circle, Triangle)
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// ���������� �����
builder.Services.AddControllers();

// ���������� Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ��������� Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestTask API V1");
        c.RoutePrefix = string.Empty; // ������������� Swagger UI �� ������ ����������
    });
}

// ��������� ��������� ��������� HTTP-��������
app.MapControllers();

// ������ ����������
app.Run();