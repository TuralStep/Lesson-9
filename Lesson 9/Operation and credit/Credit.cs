using Lesson_9.People.Client;

namespace Lesson_9.OandC.Credit;

class Credit
{
    public Guid Id { get; set; }
    public Client Client { get; set; }
    public double Amount { get; set; }
    public double Percent { get; set; }
    public short Months { get; set; }

    public Credit(Client client, double amount, double percent, short months)
    {
        Id = Guid.NewGuid();
        Client = client;
        Amount = amount;
        Percent = percent;
        Months = months;
    }

    public void CalculatePercent() => Console.WriteLine("[ Credit ] Percent calculated...");
    public void Payment() => Console.WriteLine("[ Credit ] Payment completed...");

    public override string ToString() =>
$@"---Credit---
ID : {Id}
Client name : {Client.Name}
Amount : {Amount}
Percent : {Percent}
Months : {Months}
------------";

}