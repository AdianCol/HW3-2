public sealed class OneDemensionMassive : Massive
{
    private int[] massive;

    public override void CreateMassive()
    {
        Console.WriteLine("Array length");
        massive = new int[int.Parse(Console.ReadLine())];
        var random = new Random();
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = random.Next(-200, 200);
        }
    }

    public override void AverageValue()
    {
            Console.WriteLine("Average "+massive.Average());
    }
    public override void Print()
    {
        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(" ", massive));
    }
}