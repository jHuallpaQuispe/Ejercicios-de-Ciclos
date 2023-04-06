using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int a, mayor = 0; // EL PROGRAMA TE PIDE INICIARLO PARA QUE NO TE DE ERROR
            bool Bandera = false;
            
            for(int x = 0 ; x < 10; x++){
                Console.WriteLine("INGRESE UN NUMERO: ");
                a = int.Parse(Console.ReadLine());

                if(!Bandera){  // GUARDANDO EL 1ER NUMERO PARA COMPARARLO CON LOS DEMAS
                    mayor = a;
                    Bandera = true;
                }else if(a > mayor)
                    mayor = a;
            }


            Console.WriteLine("EL NUMERO MAYOR ES: "+ mayor);
        }
    }
}
