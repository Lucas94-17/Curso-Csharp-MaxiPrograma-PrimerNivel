using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            Console.WriteLine("Ingrese el precio del articulo");
            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendidad del articulo");
            int cantidad = int.Parse(Console.ReadLine());
            int total = producto(precio,cantidad);
            Console.WriteLine(total);
        }
    

        static int producto(int a , int b){
            int r;
            r = a * b ;
            return r;
        }
    }

}
