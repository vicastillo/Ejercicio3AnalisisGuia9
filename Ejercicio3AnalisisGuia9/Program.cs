using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3AnalisisGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Programa que le solicita al usuario un valor y un arreglo de dimension y evalúa si se encuentra dentro de este";

        Double valor, iniciodesde, finhasta;

        Console.WriteLine("Ingrese el incio de la dimensión (desde):");
        iniciodesde = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el fin de la dimensión (hasta):");
        finhasta = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor a evaluar:");
        valor = Double.Parse(Console.ReadLine());

        Console.WriteLine();

        if (valor >= iniciodesde && valor <= finhasta)
        {
        Console.WriteLine("El valor si se encuentra dentro del arreglo dimensional");
        }

        
        if (valor < iniciodesde || valor > finhasta)
        {
        Console.WriteLine("El valor no se encuentra dentro del arreglo dimensional.");
        }


        Console.ReadKey();
        }
    }
}
