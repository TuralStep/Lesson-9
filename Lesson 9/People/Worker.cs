using Lesson_9.OandC.Operation;
using Lesson_9.People.Interfaces;

namespace Lesson_9.People.Worker;

class Worker : IHuman, IWork
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public string Surname { get; set; } = "Unknown";
    public short Age { get; set; }
    public int Position { get; set; }
    public double Salary { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public List<Operation> Operations { get; set; } = new();

    public Worker(string name, string surname, short age, int position, double salary, DateTime startTime, DateTime endTime, List<Operation> operations)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
        StartTime = startTime;
        EndTime = endTime;
        Operations = operations;
    }

    public void addOperation(Operation o) => Operations.Add(o);

}