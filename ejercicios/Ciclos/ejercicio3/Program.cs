using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            float i,edad,acumulador=0,cont=0,promedio;
            Console.WriteLine("Ingrese 20 edades");
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingese la edad");
                edad  = float.Parse(Console.ReadLine());

                if (edad>18)
                {
                    acumulador = edad;
                    cont++;
                }
            }
            promedio = acumulador/cont;
            Console.WriteLine(cont);
            Console.WriteLine(promedio);
        }
    }
}

