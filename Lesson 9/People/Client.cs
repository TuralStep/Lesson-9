using Lesson_9.People.Interfaces;

namespace Lesson_9.People.Client;

class Client : IHuman
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public string Surname { get; set; } = "Unknown";
    public short Age { get; set; }
    public string Live_address { get; set; } = "Unknown";
    public string Work_address { get; set; } = "Unknown";
    public double Salary { get; set; }

    public Client(string name, string surname, short age, string live_address, string work_address, double salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Live_address = live_address;
        Work_address = work_address;
        Salary = salary;
    }
}