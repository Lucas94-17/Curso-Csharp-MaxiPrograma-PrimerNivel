﻿using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num;
            Console.WriteLine("Ingrese un numero : ");
            num = int.Parse(Console.ReadLine());
            if(num > 10 ){
                Console.WriteLine("Es mayor a 10");
            }else{
                Console.WriteLine("No es mayor a 10");
            }
        }
    }
}
