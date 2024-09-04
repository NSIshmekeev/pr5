internal class Program
{
    private static void Main(string[] args)
    {
        float result = f(6) / 2 + f(13) / 2 + f(21) / 2;
        Console.WriteLine(result);
    }

    public static float f(int n) 
    {
        return (float) (Math.Sqrt(n) + n);
    }
}