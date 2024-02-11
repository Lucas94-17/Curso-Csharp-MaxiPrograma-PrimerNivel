using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num , nroPrimo = 0 ,mayor = 0,cont = 0; 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());
                
                for (int j = 1; j <= num; j++)
                {
                    if ((num%j)==0)
                    {
                        cont++;
                    }
                }
                if (i == 0 && cont == 2)
                {
                    mayor = num ;
                }
                if (cont == 2)
                {
                    nroPrimo = num ;
                }
                if(mayor < nroPrimo){
                    mayor = nroPrimo;
                }
                cont = 0 ;
            }
            if (mayor == 0)
            {
                Console.WriteLine("No hay numeros primos");
            }else{
                Console.WriteLine("El numero primo mas grande es : " + mayor);
            }
        }
    }
}
