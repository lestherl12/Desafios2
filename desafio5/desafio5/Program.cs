using desafio5;

namespace desafio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Caja> cajas = new List<Caja>();
            int cantidadCajas = 0;
            double totalVolumen = 0;

            // primero debemos ingresar la cantidad de cajas 
            Console.Write("Ingrese la cantidad de cajas: ");
            cantidadCajas = int.Parse(Console.ReadLine());

            // luego tenemos que ingresar las medidas de cada una de las cajas
            for (int i = 0; i < cantidadCajas; i++)
            {
                Caja caja = new Caja();

                Console.Write("Ingresar el alto de la caja " + (i + 1) + ": ");
                caja.Alto = double.Parse(Console.ReadLine());

                Console.Write("Ingresar el ancho de la caja " + (i + 1) + ": ");
                caja.Ancho = double.Parse(Console.ReadLine());

                Console.Write("Ingresar el largo de la caja " + (i + 1) + ": ");
                caja.Largo = double.Parse(Console.ReadLine());

                cajas.Add(caja);
            }

            // Calculamos el volumen de cada caja 
            foreach (Caja caja in cajas)
            {
                totalVolumen += caja.CalcularVolumen();
            }

            // Calculamos el promedio del volumen
            double volumenPromedio = totalVolumen / cantidadCajas;

            // Mostramos el total del volumen y el promedio del volumen
            Console.WriteLine("El volumen total de las cajas es: " + totalVolumen);
            Console.WriteLine("El volumen promedio de las cajas es: " + volumenPromedio);
        }

    }
}