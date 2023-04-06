using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            int N, MaximoPares = 0, MinimoImpares = 0;
            bool BanderaImpares = false, BanderaPares = false;

            for(int x= 0; x<20; x++){
                Console.WriteLine("INGRESE UN NUMERO: ");
                N = int.Parse(Console.ReadLine());

                // BUSCANDO LOS PARES E IMPARES

                if(N % 2 == 0){
                    //PARES
                    if(!BanderaPares){  // GUARDA EL 1ER NUMERO PAR COMO MAXIMO
                        MaximoPares = N;
                        BanderaPares = true;
                    }else if(N > MaximoPares)
                        MaximoPares = N;

                }else{ //IMPARES
                    if(!BanderaImpares){  // GUARDA EL 1ER NUMERO IMPAR COMO MINIMO
                        MinimoImpares= N;
                        BanderaImpares = true;
                    }else if (N < MinimoImpares)
                        MinimoImpares = N;
                }
            }
            Console.WriteLine("EL NRO MAXIMO DE LOS NUMEROS PARES ES: " + MaximoPares);
            Console.WriteLine("EL NRO MINIMO DE LOS NUMEROS IMPARES ES: " + MinimoImpares);


        }
    }
}
