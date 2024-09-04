internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Task2");
        DisplayTable1(-1, 6, 0.3);
        Console.WriteLine("Task3");
        DisplayTable2(-1, 6, 0.3);
    }

    public static void DisplayTable1(double a, double b, double h)
    {
        while (a < b)
        {
            Console.WriteLine($"a: {a} F(a): {F(a)}");
            a += h;
        }
    }

    public static void DisplayTable2(double a, double b, double h)
    {
        double y;
        while (a < b)
        {
            F(a, out y);
            Console.WriteLine($"a: {a} F(a): {y}");
            a += h;
        }
    }

    public static double F(double x)
    {
        if (Math.Abs(x) <= 1) return x*x - 1;
        if (Math.Abs(x) > 1 && Math.Abs(x) <= 2) return 2 * x - 1;
        return Math.Pow(x, 5) - 1;
    }

    static void F(double x, out double y)
    {
        if (Math.Abs(x) <= 1) y = x * x - 1;
        else if (Math.Abs(x) > 1 && Math.Abs(x) <= 2) y = 2 * x - 1;
        else y =  Math.Pow(x, 5) - 1;
    }
}