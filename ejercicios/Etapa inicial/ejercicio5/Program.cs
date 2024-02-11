using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            float nota1,nota2,nota3,promedio;
            Console.WriteLine("Ingrese la primera nota del alumno : ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota del alumno : ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota del alumno : ");
            nota3 = float.Parse(Console.ReadLine());
            promedio = ((nota1+nota2+nota3)/3);
            Console.WriteLine("El promedio es : " + promedio);
        }
    }
}
