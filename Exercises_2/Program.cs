
using System;

enum BankAccountType
{
    Current,
    Savings
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.1");

        BankAccountType account = BankAccountType.Current;

        Console.WriteLine($"Тип счета: {account}");
    }
}
