using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] arrayOfNumbers = new uint[3] { 15, 2, 223 };

            uint result = arrayOfNumbers[0];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                result = (arrayOfNumbers[i] < result) ? arrayOfNumbers[i] : result;
            }

            Console.WriteLine("Минимально значение в массиве равно: " + result);
            Console.ReadLine();
        }
    }
}
