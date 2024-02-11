using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int numero , resultado = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese el numero");
                numero = int.Parse(Console.ReadLine());
                resultado = par (numero);
                Console.WriteLine(resultado);
            }

        }

        static int par(int num){
            int resul = 0;
            if ((num % 2) == 0)
            {
                resul = 1 ;
            }else{
                resul = 0 ;
            }
            return resul;
        }
    }
}
