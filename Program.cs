using System;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha = new DateTime();
            Console.WriteLine($"La fecha es:  { fecha}");

            var fecha2 = new DateTime(2015, 12, 31);
            Console.WriteLine($"La fecha es:  { fecha2}");

            var fechahora = new DateTime(2015, 12, 31, 8, 30, 30);
            Console.WriteLine($"La fecha es:  { fechahora}");
            Console.WriteLine($"La fecha es:  { fechahora.ToString()}");

            Console.WriteLine($"La fecha es:  { fechahora.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"La fecha es:  { fechahora.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"La fecha es:  { fechahora.ToString("dd**MM**yyyy hh:mm:ss")}");
            Console.WriteLine($"Adicionando 10 dias a la fecha2 {fecha2.AddDays(10).ToString()}");
            Console.WriteLine($"Adicionando 10 dias a la fecha2 su dia es: {fecha2.DayOfWeek.ToString()}");
            Console.WriteLine($"El valor de la fecha con hora con la funcion date: {fechahora.Date}");

        }
    }
}
