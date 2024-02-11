using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num1,num2,num3;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());
            if((num1+num2) > (num2*num3))
                Console.WriteLine("En efecto , la suma de los dos primeros es mayor al producto del segundo con el tercero.");
            else
                Console.WriteLine("No lo es ");
        }
    }
}
