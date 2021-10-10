using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculating the max value in an array
            int[] values = new int[] { 15, 54, -9, 3, 12, -4, 99 };

            int minmum = int.MaxValue;

            for (int index = 0; index < values.Length; index++)
            {
                if (minmum > values[index])
                {
                    minmum = values[index];
                }
            }

            Console.WriteLine("the smallest number is {0}", minmum);

            for (int x = 1; x <= 10; x++)
            {
                if (x == 3)
                    continue;
                Console.WriteLine(x);
            }

            /* GETTING A RANGE OF NUMBER BETween 1 - 10
            int numRange = -1;

            while (numRange < 0 || numRange > 10)
            {
                Console.WriteLine("Please enter a number between 1 and 10");
                string playerResponse = Console.ReadLine();
                numRange = Convert.ToInt32(playerResponse);
            }

            Console.WriteLine(numRange);
            */

            //printing squares
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------");
            for (int row = 0; row < 10; row++)
            {
                for (int i = 0; i < row + 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");

            //printing a star shaped pyramid
            int numOfRows = 8;
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfRows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //Fizzbuzz challenge
            var numbers = new int[] {11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 24, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0 && numbers[i] % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (numbers[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0 && i % 3 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if ( i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

        }
    }
}
