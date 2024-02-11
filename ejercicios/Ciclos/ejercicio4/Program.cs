using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num1=-1,acumulador = 0;
            
            while(num1 != 0){
                Console.WriteLine("Ingrese un numero , si usted quiere salir , ingrese 0");
                num1 = int.Parse(Console.ReadLine());
                if (num1 != 0)
                {
                        for(int i = 1; i <= num1; i++)
                    {
                        if ((num1%i)==0)
                        {
                            acumulador++;
                        }
                    }
                    if (acumulador == 2)
                    {
                        Console.WriteLine("El numero es primo");
                    }else{
                        Console.WriteLine("No es numero primo");
                    }
                    acumulador = 0;
                }
            }
        }
    }
}
