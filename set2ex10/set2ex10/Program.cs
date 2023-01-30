using System;
namespace set2ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
            int[] numbers = { 1, 1, 2, 3, 4, 4, 4, 4, 5, 5, 6, 7, 8, 9, 9, 9, 0 };
            int count = 1;
            int vlength = numbers.Length - 1;
            int rez = 0;
            for(int i = 0; i < vlength; i++)
            {
                Console.Write(numbers[i] + " ");
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > rez)
                    {
                        rez = count;
                    }
                }

                else if ((numbers[i] != numbers[i + 1] && (numbers[i + 1] != 0)))
                {
                    count = 1;
                }
            }
            Console.WriteLine("\n" + rez);
        }
    }
}