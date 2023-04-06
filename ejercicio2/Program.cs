using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            

            int edad, acumulador = 0, contador = 0;
            float promedio;
            
            for(int x = 0; x <20; x++){
                Console.WriteLine((x+1) +") INGRESE LA EDAD: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18)
                    acumulador += edad;
                    contador++;

            }
            promedio = acumulador / contador;

            Console.WriteLine("EL PROMEDIO DE LAS PERSONAS MAYORES DE 18 AÑOS ES: "+ promedio);

        }
    }
}