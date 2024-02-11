using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num1,num2,resultado;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                resultado = num1 - num2;
                Console.WriteLine("El resultado es : " + resultado);
            }else if(num1 == num2){
                resultado = num1 + num2;
                Console.WriteLine("El resultado es : " + resultado);
            }
            else if(num1< num2){
                resultado = num1 * num2;
                Console.WriteLine("El resultado es : " + resultado);
            }
                
        }
    }
}
