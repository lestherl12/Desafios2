using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ingrese un número entero positivo: ");
        int num = int.Parse(Console.ReadLine());

        bool Primo = true;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                Primo = false;
                break;
            }
        }

        if (Primo)
        {
            Console.WriteLine("{0} es un número primo", num);
        }
        else
        {
            Console.WriteLine("{0} no es un número primo", num);
        }
        Console.ReadLine();
    }
}