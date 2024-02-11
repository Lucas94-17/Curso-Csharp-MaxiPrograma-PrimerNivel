using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 0 : declarar variables
            //tipo de dato int ,  float , char , bool , string
            int numero1,numero2 , resultado; 
            //paso 1 : pedir valor.
            Console.WriteLine("Ingrese un numero :");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            numero2 = int.Parse(Console.ReadLine());
            
            //paso 2 : realizar calulos.
            resultado = numero1 + numero2;

            //paso 3 : emitir resultado.
            Console.WriteLine(resultado);
        }
    }
}
