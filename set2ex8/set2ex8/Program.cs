using System;
namespace set2ex8
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int nr1, nr2, rez;
            nr1 = 0;
            nr2 = 1;
            rez = 1;
            for (int i = 0; i < n; i++) 
            {
                rez = nr1 + nr2;
                nr1 = nr2;
                nr2 = rez;
            }

            Console.WriteLine(rez + " este al " + n + "-lea numar din sirul lui Fibonacci.");

        }
    }
}