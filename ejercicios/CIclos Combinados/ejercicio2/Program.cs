using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int num , impares =0 , cantNumeros = 0 , porcentaje = 0 , mayorPorcentaje = 0 ,grupo = 0,numGuardado = 0,contMayor=0;
            bool bandera = false , bandera2 = false;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());
                if (num != 0 )
                {
                    bandera2 = true ; 
                }else{
                    bandera= true;
                }
                while (num !=0 )
                {
                    cantNumeros++;
                    if ((num%2)!=0)
                    {
                        impares ++;
                    }
                    
                    if (bandera2 == true)
                    {
                        numGuardado = num ;
                    }else{
                        if (num < numGuardado && num!=0 )
                        {
                            numGuardado = num;
                        }else if(num>numGuardado && num!=0){
                            bandera = true;
                        }
                    }
                    Console.WriteLine(i+1);
                    Console.WriteLine(bandera);
                    Console.WriteLine("Ingrese el numero");
                    num = int.Parse(Console.ReadLine());
                    bandera2 = false;
                }//FIN DEL WHILE
                if (cantNumeros != 0)
                {
                    porcentaje = (impares*100)/cantNumeros;
                }
                if (mayorPorcentaje < porcentaje)
                {
                    mayorPorcentaje = porcentaje;
                    grupo = i + 1;
                }
                if (bandera == false)
                {
                    contMayor++;
                }
                numGuardado=0;
                cantNumeros = 0;
                impares = 0;
                porcentaje = 0;
                bandera = false;
            }//FIN DEL FOR
            Console.WriteLine("El grupo con mayor porcentaje de numeros impares es : " + grupo);
            Console.WriteLine("La cantidad de grupos ordenados es : " + contMayor);
        }
    }
}



