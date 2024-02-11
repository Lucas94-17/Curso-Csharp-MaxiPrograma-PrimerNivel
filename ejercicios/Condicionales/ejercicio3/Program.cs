using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int importeDeVenta,importeTotal;
            Console.WriteLine("Ingrese el importe");
            importeDeVenta = int.Parse(Console.ReadLine());
            if (importeDeVenta < 1000)
            {
                Console.WriteLine("No hay descuento , el importe final es : " + importeDeVenta);
            }else if(importeDeVenta>1000 && importeDeVenta<5000){
                importeTotal = importeDeVenta - ((importeDeVenta*10)/100);
                Console.WriteLine("Se le hace un descuento del 10 % , el importe final es : " + importeTotal);
            }else if(importeDeVenta> 5000){
                importeTotal = importeDeVenta - ((importeDeVenta*18)/100);
                Console.WriteLine("Se le hace un descuento del 18 % , el importe final es : " + importeTotal);
            }
        }
    }
}
