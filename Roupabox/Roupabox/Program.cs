using System;

namespace RoupaBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cab cab = new Cab();
            cab.Cabecalho();

            Menu menu = new Menu();
            menu.ExibirMenu();
        }
    }
}
