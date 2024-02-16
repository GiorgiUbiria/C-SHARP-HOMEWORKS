using FluentValidation;
using HomeWork12.Database;
using HomeWork12.Interfaces;
using HomeWork12.Models;
using HomeWork12.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IJsonDatabase, JsonDatabase>();
builder.Services.AddTransient<IValidator<Person>, PersonValidator>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.Run();