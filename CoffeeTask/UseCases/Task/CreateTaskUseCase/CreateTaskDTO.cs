namespace CoffeeTask.UseCases.Task.CreateTaskUseCase
{
    public class CreateTaskInput
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Priority { get; set; }
        public required DateTime DueDate { get; set; }
    }

    public class CreateTaskOutPut
    { 
        public string? Id { get; set; }
    }
}