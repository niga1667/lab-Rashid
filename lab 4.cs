using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
            sum += arr[i];

        double avg = sum / n;
        Console.WriteLine($"Среднее значение массива: {avg:F3}");
    }
}
