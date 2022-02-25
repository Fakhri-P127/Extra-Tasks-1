using System;

namespace Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 15, 124, 12, -214, 99, 0, 121, -3133, 131, 341, 4241, -212 };
          
            for (int m = 0; m < numbers.Length; m++)
            {
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        int cloneOfFirst = numbers[i];
                        numbers[i] = numbers[i+1];
                        numbers[i+1] = cloneOfFirst;
                    }
                }
            }           

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }           
        }   
    }
       
}

