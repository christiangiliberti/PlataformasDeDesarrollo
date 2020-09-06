using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        
    {
        int anio = Anio("Vamos a verificar si el año en el que naciste es bisiesto\nPor favor ingresa tu año de nacimiento");
        string mensaje = "El año de nacimiento";
        mensaje += verificarSiEsBisiesto(anio) ? " es " : " no es ";
        mensaje += "bisiesto";
        Console.WriteLine(mensaje);
    }

    static int Anio(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.Parse(Console.ReadLine());
    }

    static bool verificarSiEsBisiesto (int anio)
    {
        bool resultado;
        if (anio % 4 == 0 && anio % 100 != 0 && anio % 400 != 0)
        {
            resultado = true;   
        }
        else
        {
            resultado = false;
        }

        return resultado;
    }
    }
}
