using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!"); 
        //     int acumulador=0,num1,mayor;
        //     Console.WriteLine("Ingrese el total de 10 numeros");
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine("Ingrese un numero");
        //         num1 = int.Parse(Console.ReadLine());
        //         // if(acumulador != null){
        //         //    acumulador = num1;
        //         // }
        //         if (num1 > acumulador)
        //         {
        //                 acumulador = num1;
        //         }
        //     }
        //     Console.WriteLine("El numero mas grande es : " + acumulador);
        // }
        int n,max = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero : ");
            n=int.Parse(Console.ReadLine());

            if(i == 0)
                max = n;
            else{
                if(n>max)
                    max = n;
            }
            
        }
        Console.WriteLine("El maximo es  : " + max);
    }
    }
}
