using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            // int numero = 0 , variable = 0;
            // Console.WriteLine("ingrese el numero : ");
            // numero = int.Parse(Console.ReadLine());
            // positivoNegativoCero(numero,ref variable);
            int n , suma;
            for (int i = 0; i < 3; i++)
            {
                n = int.Parse(Console.ReadLine());
                suma =  0;

                while (n != 0)
                {
                    suma += n +5;
                     n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("vuelta " + (i+1) + "La suma fue de : " + suma);
            }
        }
        // static void positivoNegativoCero (int numero,ref int variable){
        //     if (numero == 0){
        //         variable = 0;
        //     }else if((numero % 2) == 0){
        //         variable = 1;
        //     }else{
        //         variable = -1;
        //     }
        //     Console.WriteLine(variable);
        // }
        
    }
}
