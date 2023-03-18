using System;

namespace desfio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir variables
            int nota = 0;
            int sumanota = 0;
            int contadornota = 0;
            double promedio = 0.0;
            string entrada = "";

            //Instrucciones
            Console.WriteLine("Escriba la nota del alumno (del 1 a 10) y escribe 'fin' para calcular el promedio:");

            //ciclo para obtener la nota 
            do
            {
                //el usuario debe ingresar la nota 
                entrada = Console.ReadLine();

                //Si el usuario escribe un número, entonces guardarlo en la variable calificación
                if (int.TryParse(entrada, out nota))
                {
                    //Verificar que la calificación esté entre 1 y 10
                    if (nota >= 1 && nota <= 10)
                    {
                        //Agregar la calificación a la suma
                        sumanota += nota;

                        //Aumentar el contador
                        contadornota++;
                    }
                    else
                    {
                        Console.WriteLine("la nota debe estar entre 1 y 10, por favor inténtalo de nuevo.");
                    }
                }
            } while (entrada != "fin");

            //revisar que se hayan ingresado calificaciones
            if (contadornota > 0)
            {
                //Calcular el promedio
                promedio = (double)sumanota / contadornota;

                //Mostrar el promedio
                Console.WriteLine("El Puntaje promedio es: {0}", promedio);

                //Esperar que el usuario presione una tecla para cerrar
                Console.ReadKey();
            }
        }
    }
}