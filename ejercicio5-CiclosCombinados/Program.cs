using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            
            int n, con = 0;
            int i; // para contar los divisores del numero 

            for(int x = 0; x < 10; x++){

                i = 0; // acá lo inicializo porque será para cada numero

                Console.WriteLine("INGRESE UN NUMERO: ");
                n = int.Parse(Console.ReadLine());

                //VERICACION SI ES PRIMO
                for(int y = 1; y <= n; y++){
                    if(n % y== 0)
                        i++;
                }
                if(i == 2)
                    con++;
            }

            Console.WriteLine("HAY " + con + " numeros primos");



        }
    }
}
