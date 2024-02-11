using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int numero, resultado = 0 , acumulador = 0 , cont2 = 0 ;
            float  promedio = 0;
            Console.WriteLine("Ingrese el numero solicitado ");
            numero = int.Parse(Console.ReadLine());
            while (numero != 0 )
            {
                cont2 ++;
                Console.WriteLine(cont2);
                resultado = primero(numero);
                Console.WriteLine(resultado);
                if (resultado == 1)
                {
                    acumulador += numero ;
                }
                Console.WriteLine("Ingrese el numero solicitado ");
                numero = int.Parse(Console.ReadLine());
            }
            promedio = (acumulador / cont2);
            Console.WriteLine("El promedio es : " + promedio);
        }

        static int primero(int num){
            int resultado = 0 , cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                resultado = 1 ;
            }else {
                resultado = 0;
            }
            return resultado;
            resultado = 0;
        }
    }
}
