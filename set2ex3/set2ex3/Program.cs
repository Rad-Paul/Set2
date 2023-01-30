using System;
namespace set2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n. 

            int nr, sumaveche, sumanoua, produs, produsnou, produsvechi, a, b;
            nr = 10;
            a = b = 2;
            sumanoua = sumaveche = produsnou = produsvechi = produs = 0;

            for (int i = 1; i <= nr + 1; i += 2)
            {
                sumaveche += sumanoua;
                sumanoua = i + a;
                Console.WriteLine(sumaveche);
                a += 2;
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= nr + 1; i++)
            {
                produsvechi = i * (i + 1);
                produsnou = produsvechi * (b + 1);
                b++;
                // produsnou =  produsvechi * (i + 2);
                Console.WriteLine(produsvechi + "\n " + produsnou);
                //Console.WriteLine(produsnou);
            }
        }
    }
}