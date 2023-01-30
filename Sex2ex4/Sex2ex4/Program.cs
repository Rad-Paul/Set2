using System;
namespace set2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.
            int[] numbers = new int[100];
            int poz;
            int a = int.Parse(Console.ReadLine());

            if ((a > numbers.Length) || (a < 0)) 
            {
                a = -1;
                Console.WriteLine(a);
            }

            for(int i = 0; i < numbers.Length; i++) 
            {
               // Console.WriteLine(i);
                if (i == a)
                {
                    poz = i;
                    Console.WriteLine("Numarul se afla pe pozitia + " + poz);
                }
            }


        }
    }
}