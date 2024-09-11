using Tyuiu.SaigafarovBI.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SaigafarovBI.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataSevice.Addition(1,5));
            Console.WriteLine(DataSevice.Substraction(15, 5));
            Console.WriteLine(DataSevice.Multiplication(10, 10));
            Console.WriteLine(DataSevice.Division(5, 5));
            Console.ReadKey();
        }
    }
}
