using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            num2 = int.Parse(Console.ReadLine());
            int suma = num1 + num2 ;
            Console.WriteLine(suma);
            // Console.WriteLine("Hello World!");
        }
    }
}
