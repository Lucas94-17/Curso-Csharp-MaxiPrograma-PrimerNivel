using System;
using System.Reflection.Metadata;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num1,num2,num3,num4;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            num4 = int.Parse(Console.ReadLine());
            if(num1>num2 && num2>num3 && num3>num4){
                Console.WriteLine("Si estan ordenados en forma decreciente");
            }else{
                Console.WriteLine("No estan ordenados en forma decreciente");
            }
        }
    }
}
