namespace Lesson_9.People.Interfaces;

interface IHuman
{
    Guid Id { get; set; }
    string Name { get; set; }
    string Surname { get; set; }
    short Age { get; set; }
}

interface IWork
{
    int Position { get; set; }
    double Salary { get; set; }
}

interface IManage
{
    void Organize();
}