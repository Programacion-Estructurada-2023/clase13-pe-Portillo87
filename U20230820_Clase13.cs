using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //for     //foreach


            //Caso simple for

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"El numero {i}");
            } // Fin for 

            //ELABORAR TABLA DE MULTIPLICAR DE NUMERO N


            Console.WriteLine("\nIngrese un mumero para elbadorar su tabla de multipicar");
            int numero=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10; i++)
            {

             int multiplicacion  = numero * i;

             Console.WriteLine($"{numero} x {i} = {multiplicacion}");
                
            }


            //Foreach

            //Declarar una lista.

            List<int> numeros = new List<int> {24,10,8,35,14,7};

            int minimo = numeros[0]; //Inicializar con valor del indice 0
            

            foreach ( int numero1  in numeros )
            {

                if ( numero1 < minimo)
                {
                    minimo = numero1; // Actulizar el valor minimo
                }
            }

            Console.WriteLine("El numero mas pequeño en la lista  es > " + minimo);

            //VALORES POR ITERACIONES
            //1 NUMERO VALDRIA 24 MINIMO 24 Comparamos minimo = 24
            //2 NUMERO = 10 MINIMO 10 comparamos minimo = 10
            //3 NUMERO = 8  MINIMO 8  comparamos minimo = 8
            //4 NUMERO = 35 MINIMO 8  comparamos minimo = 8
            //5 NUMERO = 14 MINIMO 8  comparamos minimo = 8
            //6 NUMERO = 7  MINIMO 8  comparamos minimo = 7

           Console.ReadKey();

        }
    }
}