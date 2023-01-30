using System;
namespace set2ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
            //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
            //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
            int[] numbers = { 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0, 0, 8, 9, 0 };
            int vlength = numbers.Length - 1;
            int count = 0;
            for(int i = 0; i < vlength; i++)
            {
               // Console.Write(numbers[i] + " ");
                if (numbers[i] < numbers[i + 1] && (numbers[i + 1] != 0))
                {

                }

                else if (numbers[i] > numbers[i + 1] && (numbers[i + 1] == 0))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            
        }
    }
}