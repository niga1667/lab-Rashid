using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 5 чисел (a, b, c, d, e):");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double s = 0, k = 0;

        if (a == 0 || c == 0 || d == 0 || b == 0)
        {
            Console.WriteLine("ERROR");
            return;
        }

        s = (1.0 / 8) * (a + b - c - d);
        k = (a - c - d - b) / 2.0;

        Console.WriteLine($"s = {s:F3}");
        Console.WriteLine($"k = {k:F3}");

        
        Console.Write("Хотите повторить? (y/n): ");
        char ans = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (ans == 'y')
            Main(); 
    }
}
