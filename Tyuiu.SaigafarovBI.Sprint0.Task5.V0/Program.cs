using Tyuiu.SaigafarovBI.Sprint0.Task5.V0.Lib;
namespace Tyuiu.SaigafarovBI.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataSevice.Addition(1, 5));
            Console.WriteLine("A - B = " + DataSevice.Substraction(15, 5));
            Console.WriteLine("A * B = " + DataSevice.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataSevice.Division(5, 0));
            Console.ReadKey();
        }
    }
}
