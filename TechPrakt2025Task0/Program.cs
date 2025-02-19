using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Сума чисел: {sum}");
    }
}
