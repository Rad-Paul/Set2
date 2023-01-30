using System;
namespace set2ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
            //Console.WriteLine(oglindit(10));
            int[] numbers = { 10, 20, 95, 14 };
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += oglindit(number);    
            }

            Console.WriteLine("Suma oglinditelor din secventa este: " + sum);
        }

        public static int oglindit(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int lastdigit = number % 10;
                number = number / 10; // ex: 41 /10 = 4
                reverse = (reverse * 10) + lastdigit; // (0 * 10) + 1 reverse devine 1
            }
            return reverse;
        }
    }
}