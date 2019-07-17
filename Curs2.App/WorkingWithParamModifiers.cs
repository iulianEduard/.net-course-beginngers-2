using System;

namespace Curs2.App
{
    public class WorkingWithParamModifiers
    {
        public void CalculateSquare(int value, out int result)
        {
            result = value * value;
        }

        public float DividingNumber(int number, int numberToDivideBy, out int fractionalNumber)
        {
            int result = number / numberToDivideBy;
            fractionalNumber = number % numberToDivideBy;

            return result;
        }

        public void CalculateSum(params int[] arrayValues)
        {
            var result = 0;

            for(int i = 0; i < arrayValues.Length; i++)
            {
                result += arrayValues[i];
            }

            Console.WriteLine($"Sum is: {result}");
        }
    }
}
