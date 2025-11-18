using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; 

        TextReader saveIn = Console.In;
        TextWriter saveOut = Console.Out;

        try
        {
            using StreamReader input = new("input.txt");
            using StreamWriter output = new("output.txt");
            Console.SetIn(input);
            Console.SetOut(output);

            if (!double.TryParse(Console.ReadLine(), out double a)) throw new FormatException("Invalid a");
            if (!double.TryParse(Console.ReadLine(), out double b)) throw new FormatException("Invalid b");
            if (!double.TryParse(Console.ReadLine(), out double c)) throw new FormatException("Invalid c");
            if (!double.TryParse(Console.ReadLine(), out double d)) throw new FormatException("Invalid d");
            if (!double.TryParse(Console.ReadLine(), out double e)) throw new FormatException("Invalid e");

            double s = (1.0 / 8) * (a + b - c - d);
            double k = (a - c - d - b) / 2.0;

            Console.WriteLine($"{s:F3}");
            Console.WriteLine($"{k:F3}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
        finally
        {
            Console.SetIn(saveIn);
            Console.SetOut(saveOut);
        }
    }
}
