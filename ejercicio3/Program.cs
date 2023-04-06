using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.

            int N, contador = 0;
            Console.WriteLine("INGRESE UN NUMERO: ");
            N = int.Parse(Console.ReadLine());

            for(int x = 1; x <= N; x++){ // PARA BUSCAS LOS NUMEROS DIVISIBLES AL NUMERO INGRESADO
                if(N % x == 0)
                    contador++;
            }
            if(contador == 2)  // SI SOLO SON 2 NUMEROS DIVISIBLES ES PRIMO
                Console.WriteLine("ES PRIMO");
            else
                Console.WriteLine("NO ES PRIMO");
        }
    }
}
