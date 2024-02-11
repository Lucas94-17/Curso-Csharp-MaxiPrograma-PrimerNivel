using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            int num1,num2,num3,num4;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            num4 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3 && num1 < num4 )
                Console.WriteLine("El primer numero es el menor");
            else if (num2 < num1 && num2 < num3 && num2 < num4 )
                Console.WriteLine("El segundo numero es el menor");
            else if (num3 < num2 && num3 < num1 && num3 < num4 )
                Console.WriteLine("El tercer numero es el menor");
            else 
                Console.WriteLine("El cuarto numero es el menor");
        }
    }
}
