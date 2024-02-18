using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine()!;
        string[] arr = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Далее будем использовать arr для дальнейших операций
    }
}
