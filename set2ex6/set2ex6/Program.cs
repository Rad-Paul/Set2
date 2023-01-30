using System;
namespace set2ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere.Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
            int[] numbersA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] numbersB = { 1, 2, 3, 9, 7, 2, 6, 5, 4 };
            int n = numbersA.Length;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(numbersA[i] + " ");

                if (numbersA[i] < numbersA[i + 1])
                {
                    
                }

                else
                {
                    break;
                }
                               
            }
            
            Console.WriteLine("\n");

            for (int i = 0; i <= numbersB.Length; i++)
            {
                Console.Write(numbersB[i] + " ");

                if (numbersB[i] < numbersB[i + 1])
                {

                }

                else
                {
                    Console.WriteLine("Numerele nu sunt crescatoare. ");
                    break;
                }

            }

        }

    }
}