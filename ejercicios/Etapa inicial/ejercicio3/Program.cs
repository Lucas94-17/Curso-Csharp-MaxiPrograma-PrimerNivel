using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            float distancia , tiempo , velocidad ;
            Console.WriteLine("Ingrese la distancia entre las dos ciudades :");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora Ingrese la velocidad promedio del vehículo :");
            velocidad = float.Parse(Console.ReadLine());
            tiempo = distancia/velocidad;
            Console.WriteLine("El tiempo es : " + tiempo);
        }
    }
}
