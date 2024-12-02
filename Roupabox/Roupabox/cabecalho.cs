using System;

namespace RoupaBox
{
    internal class Cab
    {
        public void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+========================================================+");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Ryan Lima Germano");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+========================================================+");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗");
            Console.WriteLine("██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝");
            Console.WriteLine("██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░");
            Console.WriteLine("██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░");
            Console.WriteLine("██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗");
            Console.WriteLine("╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.WriteLine("+========================================================+");
            Console.ResetColor();
        }
    }
}
