using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            float num;
            Console.WriteLine("Ingrese un numero");
            num = float.Parse(Console.ReadLine());
            if(num > 0){
                Console.WriteLine("El numero es postivo");
            }else if(num < 0){
                Console.WriteLine("El numero es negativo");
            }else{
                Console.WriteLine("El numero es igual a 0");
            }
        }
    }
}
