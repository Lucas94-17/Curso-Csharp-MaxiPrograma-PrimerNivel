using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int importeTotal,cantidadLitros,importe,importeParcial;
            Console.WriteLine("Ingrese el importe : ");
            importe = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros : ");
            cantidadLitros = int.Parse(Console.ReadLine());
            if (cantidadLitros < 100)
            {
                Console.WriteLine("El importe total es :" + importe);
            }else if(cantidadLitros > 100 && cantidadLitros < 300){
                importeParcial = importe * cantidadLitros;
                importeTotal = importeParcial - ((importeParcial*10)/100);
                Console.WriteLine("El importe total es : " + importeTotal);
            }else if(cantidadLitros > 300 && cantidadLitros < 500){
                importeParcial = importe * cantidadLitros;
                importeTotal = importeParcial - ((importeParcial*15)/100);
                Console.WriteLine("El importe total es : " + importeTotal);
            }else if(cantidadLitros > 500){
                importeParcial = importe * cantidadLitros;
                importeTotal = importeParcial - ((importeParcial*25)/100);
                Console.WriteLine("El importe total es : " + importeTotal);
            }
        }
    }
}
