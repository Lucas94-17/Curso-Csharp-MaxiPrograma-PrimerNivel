using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int SueldoFijo = 15000,facturado,SueldoTotal;
            Console.WriteLine("Ingrese lo facturado por el empleado");
            facturado = int.Parse(Console.ReadLine());
            SueldoTotal = SueldoFijo + ((facturado*5)/100);
            Console.WriteLine("El sueldo total es : " + SueldoTotal);
        }
    }
}
