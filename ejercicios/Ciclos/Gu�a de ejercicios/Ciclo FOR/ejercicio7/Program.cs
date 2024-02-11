using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num,mayor=0,posicion = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el numero : ");
                num = int.Parse(Console.ReadLine());
                //Decision 
                if (i==1)
                {
                    mayor = num;
                    posicion = i;
                }else if(num > mayor){
                    mayor = num;
                    posicion = i;
                }
            }
            Console.WriteLine("El mayor numero es  : " + mayor + " con su posicion : " + posicion);
        }
    }
}
