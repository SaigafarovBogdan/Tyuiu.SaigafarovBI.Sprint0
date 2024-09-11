using Tyuiu.SaigafarovBI.Sprint0.Task6.V0.Lib;
namespace Tyuiu.SaigafarovBI.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] {1,2,3,4,5};
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элментов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Произведение элементов массива = " + DataService.AdditionArray(arraynums));
            Console.ReadKey();
        }
    }
}
