namespace CoffeeTask.UseCases.Task.UpdateTaskUseCase
{
    public class UpdateTaskInput
    {
        public required string? Name { get; set; }
        public required string? Description { get; set; }
        public required int? Priority { get; set; }
        public required DateTime? DueDate { get; set; }
    }

    public class UpdateTaskOutPut
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Priority { get; set; }
        public required DateTime DueDate { get; set; }
    }
}