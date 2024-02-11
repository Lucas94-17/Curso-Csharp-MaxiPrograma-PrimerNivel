using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num , mayor = 0;
            for(int i = 0 ; i<5 ; i++){
                Console.WriteLine("Ingrese un numero  : ");
                num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = num;
                }else if(mayor < num){
                    mayor = num;
                }
            }
            Console.WriteLine("El mayor numero es : " + mayor);
        }
    }
}
