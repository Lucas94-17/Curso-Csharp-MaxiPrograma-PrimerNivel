using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num , cont= 0 , cont2=0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("INGRESE UN NUMERO");
                num = int.Parse(Console.ReadLine());
                for (int j = 1; j <= num; j++)
                {
                    if ((num%j) == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    cont2 ++;
                }
                
                cont = 0 ;
            }
            Console.WriteLine("La cantidad de numeros primos es : " + cont2);
        }
    }
}
