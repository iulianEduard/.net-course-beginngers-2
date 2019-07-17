using System;

namespace Curs2.App
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void IfStatementExample1()
        {
            Console.WriteLine("*** Example 1 ***");
            Console.WriteLine("Enter your name:");
            var input = Console.ReadLine();

            if(input.Length < 10)
            {
                Console.WriteLine($"Name entered: {input} has less than 10 characters");
            }
            else
            {
                Console.WriteLine($"Name entered: {input} has more than 10 characters");
            }

            Console.ReadKey();
        }

        static void IfStatementExample2()
        {
            Console.WriteLine("*** Example 2 ***");
            Console.WriteLine("Enter value for a:");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for b:");
            var b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine($"a: {a} is greater than b: {b}");
            }
            else if(a == b)
            {
                Console.WriteLine($"a: {a} equals to b: {b}");
            }
            else
            {
                Console.WriteLine($"a: {a} is smaller than b: {b}");
            }

            Console.ReadKey();
        }

        static void SwitchExmaple()
        {
            Console.WriteLine("*** Example 1 ***");
            Console.WriteLine();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Download music");
            Console.WriteLine("2. Download movies");
            Console.WriteLine("3. Download tv shows");
            Console.WriteLine("4. Download pictures");

            var selectedValue = Convert.ToInt32(Console.ReadKey());

            switch(selectedValue)
            {
                case 1:
                    Console.WriteLine("You have selected option 1. Download music");
                    Console.WriteLine("Starting download process");
                    break;
                case 2:
                    Console.WriteLine("You have selected option 2. Download movies");
                    Console.WriteLine("Starting download process");
                    break;
                case 3:
                    Console.WriteLine("You have selected option 3. Download tv shows");
                    Console.WriteLine("Starting download process");
                    break;
                case 4:
                    Console.WriteLine("You have selected option 1. Download pictures");
                    Console.WriteLine("Starting download process");
                    break;
                default:
                    Console.WriteLine("Entered option is invalid");
                    break;
            }
        }

        static void WhileExample1()
        {
            Console.WriteLine("*** Example 1 ***");
            Console.WriteLine("Counting from 0 to 10:");

            int index = 0;
            while(index <= 10)
            {
                Console.WriteLine($"Index value: {index}");
                index++;
            }

            Console.ReadKey();

            Console.WriteLine("*** Example 2 ***");
            Console.WriteLine("Counting from 10 to 0:");

            int indexer = 10;
            while (indexer >= 0)
            {
                Console.WriteLine($"Index value: {indexer}");
                indexer--;
            }

            Console.ReadKey();
        }

        static void DoWhileExample1()
        {
            Console.WriteLine("*** Example 1 ***");
            Console.WriteLine("Counting from 0 to 10:");

            int index = 0;
            do
            {
                Console.WriteLine($"Index value: {index}");
                index++;
            }
            while (index <= 10);

            Console.ReadKey();

            Console.WriteLine("*** Example 2 ***");
            Console.WriteLine("Counting from 10 to 0:");

            int indexer = 10;
            do
            {
                Console.WriteLine($"Index value: {indexer}");
                indexer--;
            }
            while (indexer >= 0);


            Console.ReadKey();
        }

        static void ForExample1()
        {
            Console.WriteLine("*** Example 1 ***");
            Console.WriteLine("Counting from 0 to 10:");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Index: {i}");
            }

            Console.ReadKey();

            Console.WriteLine("*** Example 2 ***");
            Console.WriteLine("Counting from 10 to 0:");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Index: {i}");
            }

            Console.ReadKey();
        }

        static void ArrayExample1()
        {
            Console.WriteLine("*** Example 1 ***");
            int[] intArray = new int[6];

            for(int i = 1; i <= intArray.Length; i++)
            {
                Console.WriteLine($"Value of i: {intArray[i]}");
            }

            Console.WriteLine("Provide lenght:");
            int lenght = Convert.ToInt32(Console.ReadLine());

            int[] dynamicArray = new int[lenght];

            Console.WriteLine("Populate array:");

            for(int i = 0; i <= lenght; i++)
            {
                Console.WriteLine($"Provide value for i: {dynamicArray[i]}");
                int value = Convert.ToInt32(Console.ReadLine());
                dynamicArray[i] = value;
            }

            Console.WriteLine("Display data from array");

            for(int i = 0; i <= lenght; i++)
            {
                Console.WriteLine($"Value is: {dynamicArray[i]}");
            }

            Console.ReadKey();
        }

        static void ArrayExample2()
        {
            Console.WriteLine("*** Example 2 ***");
  
            Console.WriteLine("Provide lenght:");
            int lenght = Convert.ToInt32(Console.ReadLine());

            string[] dynamicArray = new string[lenght];

            Console.WriteLine("Populate array:");

            for (int i = 0; i <= lenght; i++)
            {
                Console.WriteLine($"Provide value for i: {dynamicArray[i]}");
                dynamicArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Display data from array");

            for (int i = 0; i <= lenght; i++)
            {
                Console.WriteLine($"Value is: {dynamicArray[i]}");
            }

            Console.ReadKey();
        }

        static void ForeachExample1()
        {
            string[] _array = new string[] { "january", "february", "march", "april"};

            foreach(var item in _array)
            {
                Console.WriteLine($"Item value is: {item}");
            }
        }

        static void MethodOverrides()
        {
            var calculations = new Calculations();

            Console.WriteLine("Calculating sum of 2 numbers");
            Console.WriteLine($"Sum of 1 and 2 is {calculations.Sum(1, 2)}");

            Console.WriteLine("Calculating sum of 3 numbers");
            Console.WriteLine($"Sum of 1, 2 and 3 is {calculations.Sum(1, 2, 3)}");

            Console.WriteLine("Calculating sum of 4 numbers");
            Console.WriteLine($"Sum of 1, 2, 3 and 4 is {calculations.Sum(1, 2, 3, 4)}");

            Console.ReadKey();
        }

        static void ParamModifiers()
        {
            var workingWithParamModifiers = new WorkingWithParamModifiers();

            Console.WriteLine("Working with ***out***");
            Console.WriteLine("Calculate square number");
            workingWithParamModifiers.CalculateSquare(4, out int result);
            Console.WriteLine($"Value is: {result}");

            Console.ReadKey();

            Console.WriteLine("Dividing numbers");
            int a = 5;
            int b = 2;
            int rest;
            Console.WriteLine($"Catul impartirii este: {workingWithParamModifiers.DividingNumber(a, b, out rest)}");

            Console.ReadKey();

            Console.WriteLine("Working with *** params ****");
            Console.WriteLine($"Sum of values: 5, 6, 7, 8 is");
            workingWithParamModifiers.CalculateSum(5, 6, 7, 8);

            Console.ReadKey();

            Console.WriteLine($"Sum of values: 1, 2, 3, 4 given by array is");
            int[] values = { 1, 2, 3, 4 };
            workingWithParamModifiers.CalculateSum(values);

            Console.ReadKey();
        }
    }
}