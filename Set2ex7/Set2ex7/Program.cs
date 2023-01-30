using System;
namespace set2ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

            int[] numbers = { 5, 243, 72, 73, 25, 992, 298, 566, 828, 314};
            //int maxValue = numbers.Max();
            //int minValue = numbers.Min();
            int n = numbers.Length;
            int max = numbers[0];
            int min = numbers[0];
            /*for(int i = 0; i < n - 1; i++)
            {
                //Console.Write(numbers[i] + " ");

                if (numbers[i] < numbers[i + 1])
                {
                    max = numbers[i + 1];
                }

                else if (numbers[i] > numbers[i + 1])
                {
                    max = numbers[i];
                }

            }

            Console.WriteLine(max);
            */

            foreach(int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }

            }

            Console.WriteLine("Numarul cel mai mare: " + max);
            Console.WriteLine("Numarul cel mai mic: " + min);
        }
    }
}