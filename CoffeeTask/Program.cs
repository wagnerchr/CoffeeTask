using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using CoffeeTask.UseCases.Task.GetTaskUseCase;
using CoffeeTask.UseCases.Task.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DbService>();

// Repositories
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ICreateTaskUseCase, CreateTaskUseCase>();
builder.Services.AddScoped<IGetTaskUseCase, GetTaskUseCase>();


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
