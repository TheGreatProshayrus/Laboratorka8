
    public class Program
    {
        delegate int Average(int a, int b, int c);

        static void Main(string[] args)
        {
            Average mid = (a, b, c) => (a + b + c) / 3;

            Console.WriteLine(mid(423, 555, 109));
            Console.ReadLine();
        }
    }
