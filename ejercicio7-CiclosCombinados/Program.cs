using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            
            int N = 0, contador, NumeroGrupo = 0;

            while(N >= 0){
                contador = 0;
                NumeroGrupo++;

                Console.WriteLine("INGRESE UN NUMERO: ");
                N = int.Parse(Console.ReadLine());

                while(N > 0){
                    contador++;

                    Console.WriteLine("INGRESE UN NUMERO: ");
                    N = int.Parse(Console.ReadLine());        
                }
                Console.WriteLine("EN EL GRUPO "+ NumeroGrupo + "EXISTEN " + contador + " NUMEROS");
            }
        }
    }
}
