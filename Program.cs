using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string preparar = "Preparar...";
            string Apontar = "Apontar...";
            string FOGO = "FOGO!";
            string Aviso = "Aperte a Tecla \"ENTER\"";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Aviso);
            Console.WriteLine(" 3 VEZES. ");
            Console.ReadLine();
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(preparar);
            Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Apontar);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(FOGO);
            
            Console.ResetColor();
        }
    }
}
