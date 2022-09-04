using Lesson_9.People.Interfaces;

namespace Lesson_9.People.CEO;

class CEO : IHuman, IWork, IManage
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public string Surname { get; set; } = "Unknown";
    public short Age { get; set; }
    public int Position { get; set; }
    public double Salary { get; set; }

    public CEO(string name, string surname, short age, int position, double salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public void Control() => Console.WriteLine("CEO is controlling...");
    public void Organize() => Console.WriteLine("CEO is organizing...");
    public void MakeMeeting() => Console.WriteLine("CEO is making meeting...");
    public void DecreasePercentage(double amount) => Console.WriteLine($"CEO decreased percentages {amount}%...");

}