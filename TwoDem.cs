public sealed class TwoDemensionMassive : Massive
{
    private int[,] massive;

    public override void CreateMassive()
    {
        Console.WriteLine("Array length by string in format: len1 len2");
        string[] a = Console.ReadLine().Split();
        massive = new int[int.Parse(a[0]), int.Parse(a[1])];
        var random = new Random();
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                massive[i, j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                sum += massive[i, j];
                count++;
            }
        }
        Console.WriteLine("Average "+sum / count);
    }
    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write(massive[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}