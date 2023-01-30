using System;
namespace set2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int count = 0;

            for(int i = 0; i <= numbers.Length; i++)
            {
                if((i > 0) && (i % 2 == 0))
                {
                    count++;
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("Sunt pare: " + count);   
        }
    }

}
