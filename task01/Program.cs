using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine()!;
        string[] arr = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    }
    static string[] GetShortStrings(string[] arr)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] newArr = new string[count];
        int index = 0;
        foreach (var item in arr)
        {
            if (item.Length <= 3)
            {
                newArr[index++] = item;
            }
        }

        return newArr;
    }
}

