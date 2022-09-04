namespace Lesson_9.OandC.Operation;

class Operation
{
    public Guid Id { get; set; }
    public string Process_name { get; set; } = "Unknown";
    public DateTime CompletedTime { get; set; }

    public Operation(string process_name, DateTime completedTime)
    {
        Id = Guid.NewGuid();
        Process_name = process_name;
        CompletedTime = completedTime;
    }
}