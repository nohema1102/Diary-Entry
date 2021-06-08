using System;
using System.IO;
using System.Globalization;

namespace Diary_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola! Bienvenido a tu diario, ¿Qué está pasando hoy? [Por favor, empieza a escribir]");
             string textoDiario = Console.ReadLine();

             DateTime hoy = DateTime.Now;
             CultureInfo cultura = new CultureInfo("es-MX");
             string hoyString = hoy.ToString(cultura);

             using (StreamWriter sw = new StreamWriter(hoyString))
             {
                 sw.WriteLine(textoDiario);
             }
            Console.WriteLine(hoyString);
        }
    }
}
