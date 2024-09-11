namespace Tyuiu.SaigafarovBI.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int Length = 5;
            int[] resultArray = new int[Length];
            for (int i = 0;i<Length;++i)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
