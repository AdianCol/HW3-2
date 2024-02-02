public sealed class JaggedMassive : Massive
{
    private int[][] massive;

    public override void CreateMassive()
    {
        Console.WriteLine("Array length");
        massive = new int[int.Parse(Console.ReadLine())][];
        var random = new Random();
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            Console.WriteLine("Row length");
            massive[i] = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < massive[i].Length; j++)
            {
                massive[i][j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            for (int j = 0; j < massive[i].Length; j++)
            {
                sum += massive[i][j];
                count++;
            }
        }
        Console.WriteLine("Average "+sum/count);
    }
    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < massive.Length; i++)
        {
            Console.Write($"Row {i}: ");
            Console.WriteLine(string.Join(" ", massive[i]));
        }
    }
}