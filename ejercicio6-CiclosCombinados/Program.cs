using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int N, conImpares, conNumeros, x, mayor = 0, ContadorGruposOrdenados = 0, NumGrupo = 0;

            float PorcentajeImpares, MayorPorcentaje = 0;

            bool ban1, ban2, verificador; 
            ban2 = false; // para guardar el 1er porcentaje mayor


            for(x = 0; x < 5; x++){  // son 5 grupos

                Console.WriteLine("INGRESE UN NUMERO: ");
                N = int.Parse(Console.ReadLine());

                verificador = true; // para suponer que esta ordenado

                ban1 = false;  // para guardar el primer numero

                conNumeros = 0;  // Aca porque es para cada grupo 
                conImpares = 0;  //Aca lo mismo, para cada grupo

                while(N != 0){  // separados por un cero
                    conNumeros++;

                    if(!(N % 2 == 0))
                        conImpares++;
                    
                    // PARA VERIFICAR SI ESTA ORDENADO DE M A ME
                    if(!(ban1)){
                        mayor = N;
                        ban1 = true;
                    }else if(N <= mayor)
                        mayor = N;
                    else
                        verificador = false; // si llega aca es que no esta ordenado

                    Console.WriteLine(x+1 +") INGRESE UN NUMERO O CERO PARA TERMINAR EL GRUPO: ");
                    N = int.Parse(Console.ReadLine());
                        
                }

                // HALLANDO EL PORCENTAJE MAYOR DE IMPARES DE CADA GRUPO
                PorcentajeImpares = (conImpares * 100) / conNumeros;

                if(!(ban2)){ // esta bandera no es necesario si se pide maximo porque lo inicialize en cero el "mayorporcentaje"
                    MayorPorcentaje = PorcentajeImpares;
                    NumGrupo = x +1;
                    ban2 = true;
                }else if (PorcentajeImpares > MayorPorcentaje){
                    MayorPorcentaje = PorcentajeImpares;
                    NumGrupo = x +1;
                }

                if(verificador)
                    ContadorGruposOrdenados++;

            }
            
            Console.WriteLine("EL NUMERO DE GRUPO CON MAYOR PORCENTAJE DE IMPARES ES EL GRUPO: "+ NumGrupo);
            Console.Write("\tCON UN PORCIENTO: "+ MayorPorcentaje + "%");

            Console.WriteLine("EXISTEN " + ContadorGruposOrdenados + " GRUPOS ORDENADOS ");
        }
    }
}
