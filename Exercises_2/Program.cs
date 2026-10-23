
using System;

enum University
{
    KGU,
    KAI,
    KHTI
}

struct Worker
{
    public string Name;
    public University UniversityName;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Домашнее задание 3.1");

        Worker worker = new Worker();

        worker.Name = "Иван";
        worker.UniversityName = University.KGU;

        Console.WriteLine($"Имя: {worker.Name}");
        Console.WriteLine($"Вуз: {worker.UniversityName}");
    }
}
