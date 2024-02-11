using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            int [] vectorNuevo = new int[50];
            int [] mayoresPromedio = new int [50];
            int promedio , cont = 0,acumulador = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la cantidad ");
                vectorNuevo[i] = int.Parse(Console.ReadLine());
                acumulador += vectorNuevo[i];
                cont++;
            }
            
            promedio = acumulador / cont;
            Console.WriteLine("El promedio es : " + promedio);
            for (int x = 0; x < 3; x++)
            {
                if (vectorNuevo[x] > promedio)
                {
                    Console.WriteLine("El valor : " + vectorNuevo[x] + " es mayor al promedio");
                }
            }
        }
    }
}
