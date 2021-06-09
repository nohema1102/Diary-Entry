using System;
using System.IO;
using System.Globalization;

namespace Diary_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            
             DateTime hoy = DateTime.Now;
             CultureInfo cultura = new CultureInfo("es-MX");
             string hoyString = hoy.ToString("d/M/yyyy");
             string hoyReplace = hoyString.Replace("/", "-"); 

             Console.WriteLine("¡Hola! Bienvenido a tu diario, ¿Qué está pasando hoy? [Por favor, empieza a escribir]");
             string textoDiario = Console.ReadLine();


             using (StreamWriter sw = new StreamWriter(hoyReplace))
             {
                 sw.WriteLine(textoDiario);
             }
          
        }
    }
}
