
using System;

enum BankAccountType
{
    Current,
    Savings
}

struct BankAccount
{
    public string Number;
    public BankAccountType Type;
    public decimal Balance;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.2");

        BankAccount account = new BankAccount();

        account.Number = "123456";
        account.Type = BankAccountType.Current;
        account.Balance = 15000m;

        Console.WriteLine($"Номер счета: {account.Number}");
        Console.WriteLine($"Тип счета: {account.Type}");
        Console.WriteLine($"Баланс: {account.Balance}");
    }
}
