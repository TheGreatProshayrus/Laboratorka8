delegate int ReturnsInt();
delegate int Operation(ReturnsInt[] delegates);

internal class Program
{
    static void Main(string[] args)
    {
        Operation op = (delegates) =>
        {
            long sum = 0;

            foreach (var d in delegates)
                sum += d();

            return (int)sum / delegates.Length;
        };

        ReturnsInt[] delegates = new ReturnsInt[45];
        Random rand = new Random();

        for (int i = 0; i < delegates.Length; i++)
            delegates[i] = rand.Next;

        Console.WriteLine(op(delegates));
        Console.ReadLine();
    }
}