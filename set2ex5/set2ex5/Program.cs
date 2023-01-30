using System;
using System.Diagnostics.Metrics;

namespace set2ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
            //Se considera ca primul element din secventa este pe pozitia 0. 
            int[] numbers = { 0, 1, 2, 7, 4, 20, 6, 17, 10, 9 };

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}