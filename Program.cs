using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк:
        // указать null для последующего ввода с клавиатуры
        // задать массив в коде изначально, например string[] sourceArray = { "Hello", "2", "world", ":-)" }; 

        string[] sourceArray = null;
        if (sourceArray == null)
        {
            
            Console.WriteLine("Введите строки через пробел:");
            string input = Console.ReadLine();
            sourceArray = input.Split(' ');
        }

        int count = 0;
        foreach (string str in sourceArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in sourceArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        Console.WriteLine("[" + string.Join(", ", sourceArray) + "] -> [" + string.Join(", ", resultArray) + "]");
    }
}