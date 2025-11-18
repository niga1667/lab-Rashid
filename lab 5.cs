using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int m = int.Parse(Console.ReadLine());

        double[,] matrix = new double[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"[{i},{j}] = ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write($"{matrix[i, j],6}");
            Console.WriteLine();
        }
    }
}
