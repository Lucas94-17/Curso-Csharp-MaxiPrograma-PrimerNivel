using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.


            int indice = 0, articuloMayor , mayor = 0 ,contador = 0 ,numero = 0 , cantidadVen =0 , cantidadVendida10 = 0;
            int [] articulo = new int[20];
            int [] cantidadVendida = new int [20];
            int [] vectorContador = new int[20];
            Console.WriteLine("Ingrese un articulo del 1 al 15 , para salir presione 0");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida de dicho producto");
            cantidadVen = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                 if (numero == 10)
                {
                    cantidadVendida10 = cantidadVendida10 + cantidadVen;
                }
                cantidadVendida[indice] = cantidadVen;
                articulo[indice] = numero;
                Console.WriteLine("Ingrese el numero o para salir presione 0");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    Console.WriteLine("Ingrese la cantidad vendida de dicho producto");
                    cantidadVen = int.Parse(Console.ReadLine());
                }
                indice++;
               
            }
            Console.WriteLine("La cantidad vendida de articulo 10 es : " + cantidadVendida10 + "\n");
            for (int i = 0; i < indice; i++)
            {
                
                for (int j = 1; j <= 15; j++)
                {
                    if (articulo[i] == j)
                    {
                        vectorContador[j] = vectorContador[j] + 1;
                    }
                }
            
            }
            for (int k = 1; k <= 15; k++)
            {
                if (mayor < vectorContador[k])
                {
                    mayor = vectorContador[k];
                    indice = k;
                }
            }
            Console.WriteLine("el indice es  : " + indice + " y la cantidad de veces que se repitió es : " + mayor + "\n");
            for (int l = 1; l <= 15; l++)
            {
                if (vectorContador[l] == 0)
                {
                    Console.WriteLine("En la posición : " + l + " no se registraron ventas");
                }
            }            
        }
    }
}
