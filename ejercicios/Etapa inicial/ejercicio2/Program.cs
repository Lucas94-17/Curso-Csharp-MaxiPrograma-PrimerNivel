using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num1,cubo;
            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            cubo = num1*num1*num1;
            Console.WriteLine("El Cubo del numero es : " + cubo);
        }
    }
}
