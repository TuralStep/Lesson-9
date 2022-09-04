using Lesson_9.People.Interfaces;

namespace Lesson_9.People.Manager;

class Manager : IHuman, IWork, IManage
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public string Surname { get; set; } = "Unknown";
    public short Age { get; set; }
    public int Position { get; set; }
    public double Salary { get; set; }

    public Manager(string name, string surname, short age, int position, double salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public void Organize() => Console.WriteLine("Manager is organizing...");
    public void CalculateSalaries() => Console.WriteLine("Manager is calculating salaries...");
}