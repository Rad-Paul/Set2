using System;
namespace set2ex2
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
            int zero = 0;
            int negative = 0;
            int positive = 0;
            int[] numbers = new int[5];
            Console.WriteLine("Introduceti numerele dorite: ");

            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            numbers[3] = int.Parse(Console.ReadLine());
            numbers[4] = int.Parse(Console.ReadLine());

            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    zero++;
                }
                else if (number > 0) 
                {
                    positive++;
                }
                else if (number < 0)
                {
                    negative++;
                }
            }

            Console.WriteLine("Numere egale cu zero: " + zero + "\nNumere pozitive: " + positive + "\nNumere negative: " + negative);
        }
    }
}