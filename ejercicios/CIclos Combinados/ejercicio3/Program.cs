using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int num , contador = 0 ;
            Console.WriteLine("Ingrese el numero");
            num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                while (num != 0)
                {
                    if (num > 0)
                    {
                        contador ++;
                    }else{
                        Console.WriteLine("Usted a ingresado un numero negativo , vuelva a intentarlo");
                    }
                    Console.WriteLine("Ingrese el numero");
                    num = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad de numeros de esta lista es : " + contador);
                contador = 0;
                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
