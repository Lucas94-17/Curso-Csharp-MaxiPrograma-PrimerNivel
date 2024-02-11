using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int [] vectorNuevo= new int[20];
            int mayor = 0, posición = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entero");
                vectorNuevo[i] = int.Parse(Console.ReadLine());
            } 
            for (int i = 0; i < 10; i++)
            {
                // Console.WriteLine(vectorNuevo[i]);
                if (i == 0)
                {
                    mayor = vectorNuevo[i];
                }else if(vectorNuevo[i] >= mayor){
                    mayor = vectorNuevo[i];
                    posición = i ; 
                }
                
            }
            Console.WriteLine("El mayor numero es  : " + mayor + " y su posicion es  : " + posición);
        }
    }
}
