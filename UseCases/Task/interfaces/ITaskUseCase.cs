﻿using CoffeeTask.Entities;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using CoffeeTask.UseCases.Task.GetTaskUseCase;
using CoffeeTask.UseCases.Task.UpdateTaskUseCase;

namespace CoffeeTask.UseCases.Task.interfaces
{
    public interface ICreateTaskUseCase
    {
        Task<bool> CreateTask(CreateTaskInput task);
    }

    public interface IGetTaskUseCase 
    {
        Task<TaskEntity?> GetTask(GetTaskInput id);
    }

    public interface IGetAllTasksUseCase
    {
        Task<List<TaskEntity?>> GetAllTasks();
    }
    public interface IUpdateTaskUseCase
    {
        Task<TaskEntity?> UpdateTask(string id, UpdateTaskInput task);
    }
}
