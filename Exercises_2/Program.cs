
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Лабораторная работа 3");
        Console.WriteLine("1 - Упражнение 3.1");
        Console.WriteLine("2 - Упражнение 3.2");
        Console.WriteLine("3 - Домашнее задание 3.1");

        Console.Write("Выберите номер: ");
        string number = Console.ReadLine()!;

        if (number == "1")
        {
            Exercise_3_1.Run();
        }
        else if (number == "2")
        {
            Exercise_3_2.Run();
        }
        else if (number == "3")
        {
            DZ_3_1.Run();
        }
        else
        {
            Console.WriteLine("Неверный номер");
        }
    }
}
