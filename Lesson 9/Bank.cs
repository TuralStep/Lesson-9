using Lesson_9.People.CEO;
using Lesson_9.People.Worker;
using Lesson_9.People.Manager;
using Lesson_9.People.Client;
using Lesson_9.OandC.Credit;

namespace Lesson_9.Bank;

class Bank
{
    public string Name { get; set; } = "Unknown";
    public double Budget { get; set; }
    public double Profit { get; set; }
    public CEO CEO { get; set; }
    public List<Worker> Workers { get; set; } = new();
    public List<Manager> Managers { get; set; } = new();
    public List<Client> Clients { get; set; } = new();
    public List<Credit> Credits { get; set; } = new();

    public void CalculateProfit() => Console.WriteLine("[ BANK ] Profit calculated...");
    
    public void ShowClientCredit(string fullname)
    {
        Credit? c = null;
        foreach (var credit in Credits)
        {
            if (credit.Client.Name == fullname)
            {
                c = credit;
                break;
            }
        }
        if (c == null)
        {
            throw new ArgumentException($"No credit for {fullname} exists...");
        }

        Console.WriteLine(c);

    }

    public void PayCredit(Client c,double money)
    {
        Credit? cc = null;
        foreach (var credit in Credits)
        {
            if (credit.Client.Name == c.Name)
            {
                cc = credit;
                break;
            }
        }
        if (cc == null)
        {
            throw new ArgumentException($"No credit for {c.Name} exists...");
        }
        if (money > cc.Amount)
        {
            throw new ArgumentException($"{money}$ is too much. Pls pay at max {cc.Amount}$");
        }

        cc.Amount -= money;

    }

    public void ShowAllCredit()
    {
        foreach (var item in Credits)
        {
            Console.WriteLine(item);
        }
    }


}