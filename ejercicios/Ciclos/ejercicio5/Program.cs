using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        int num,maxPar = 0,minImpar = 0,contPar = 0,contImpar = 0;
        Console.WriteLine("Debe ingresar 20 numeros");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese el numero : ");
                num = int.Parse(Console.ReadLine());
                //Trabajo con los impares
                if((num%2)!= 0)
                {
                    // if (i==0)
                    // {
                    //     impares = num1;
                    // }else if(num1 < impares){
                    //     impares = num1;
                    // }
                    // ESTO TAMBIEN SE PUEDE HACER CON UNA BANDERA , DE LA FORMA EN QUE LA BANDERA INICIE EN FALSE , Y CUANDO YA SE HAYA ASIGNADO UN VALOR CAMBIE A TRUE.
                    contImpar++;
                    if (contImpar == 1){
                        minImpar = num;
                    }else if(num < minImpar){
                        minImpar = num;
                    }
                }
                //Trabajo con los pares
                if((num%2) == 0){
                    // if (i==0)
                    // {
                    //     pares = num1;
                    // }else if (num1 > pares)
                    // {
                    //     pares = num1;   
                    // }
                    contPar++;
                    if (contPar == 1){
                        maxPar = num;
                    }else if(maxPar < num){
                        maxPar = num;
                    }
                }
            }
            Console.WriteLine("El numero par mas alto es : " + maxPar + " y el numero mas chico de los impares es : " + minImpar);
        }
    }
}
