using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num,contador = 0;
            for(int i = 0 ; i < 5 ; i++){
                Console.WriteLine("Ingrese el " + (i+1) + " numero");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
        }
    }
}
