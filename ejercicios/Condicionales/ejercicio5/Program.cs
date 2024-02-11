using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
              int num1,num2,num3,num4;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            num4 = int.Parse(Console.ReadLine());

            if (num1 > 100 )
                Console.WriteLine("El primer numero es mayor a 100");
            if (num2 > 100)
                Console.WriteLine("El segundo numero es mayor a 100");
            if (num3 > 100)
                Console.WriteLine("El tercer numero es mayor a 100");
            if(num4 > 100)
                Console.WriteLine("El cuarto numero es mayor a 100");
        }
        }
}
