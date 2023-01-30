using System;
namespace set2ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine daca o secventa de n numere este monotona.
            //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

            int[] numbers = { 3, 3, 8, 15, 23, 25, 47, 50, 78, 80, 0 };
            int[] numbers2 = { 68, 47, 47, 40, 35, 41, 25, 20, 11, 4, 0 };
            int v1length = numbers.Length - 1;
            int v2length = numbers2.Length - 1;
            for(int i = 0; i < v1length; i++) //crescatoare
            {
                Console.Write(numbers[i] + " ");
                if (numbers[i] <= numbers[i + 1])
                {

                }

                else if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine("\nSecventa este crescatoare pana la al " + (i + 1) + "-lea numar.\n");
                    break;
                }
            }

            for (int i = 0; i < v2length; i++)
            {
                Console.Write(numbers2[i] + " ");

                if (numbers2[i] > numbers2[i + 1])
                {

                }

                else if (numbers2[i] < numbers2[i + 1])
                {
                    Console.WriteLine("\nDescrescatoare pana la pozitia " + (i + 1) );
                    break;
                }
            }
        }
    }
}