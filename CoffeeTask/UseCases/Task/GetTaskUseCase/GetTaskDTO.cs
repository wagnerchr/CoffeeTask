namespace CoffeeTask.UseCases.Task.GetTaskUseCase
{
    public class GetTaskInput
    {
        public required string Id { get; set; }
    }

    public class GetTaskOutput
    {
        public required string? Name { get; set; }
        public required string? Description { get; set; }
        public required int? Priority { get; set; }
        public required DateTime? CreationDate { get; set; }
        public required DateTime? DueDate { get; set; }
    }
}