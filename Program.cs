using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] condensed = new int[numbers.Length];
            int elements=numbers.Length;
            int counter = 0;

            while (elements > 1)
            {
                for (int i = 0; i < elements - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        condensed[i] += numbers[i + j];
                    }
                    counter++;
                }
                for(int i= 0; i < counter; i++)
                {
                    numbers[i] = condensed[i];
                }
                counter = 0;
                elements--;
 
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = 0;
                }           
            }
            Console.WriteLine(numbers[0]);

            Console.ReadLine();
        }
    }
}
