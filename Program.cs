using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double a, b;
        Console.WriteLine("Nhập A: ");
        a = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a phải khác 0");

        }
        else
        {
            Console.WriteLine("Nhập B:");
            b = Convert.ToDouble(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine("{0}x + {1} = 0\n=> x = {2}", a, b, x);

        }
        Console.WriteLine();
    }
}