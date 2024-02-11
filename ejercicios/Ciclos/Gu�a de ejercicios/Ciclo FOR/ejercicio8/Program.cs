using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num,menor=0,posicion = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el numero : ");
                num = int.Parse(Console.ReadLine());
                //Decision 
                if(i==1)
                {
                    menor = num;
                    posicion = i;
                }else if(num < menor){
                    menor = num;
                    posicion = i;
                }
            }
            Console.WriteLine("El menor numero es  : " + menor + " con su posicion : " + posicion);
        }
    }
}
