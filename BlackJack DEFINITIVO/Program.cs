using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0;
            int carta2 = 0;
            int carta = 0;
            int Total = 0;
            string continuar = "s";

            while (continuar=="s"&& Total < 21)
            {
                if (Total == 0)
                {
                    Console.WriteLine("Que comience el juego :v");
                    carta1 = aleatorio.Next(1, 11);
                    carta2 = aleatorio.Next(1, 11);
                    Total = carta1 + carta2;
                    Console.WriteLine("Carta 1: " + carta1);
                    Console.WriteLine("Carta 2: " + carta2);
                    Console.WriteLine("Total de puntos: " + Total);
                }else if (Total < 21)
                {
                    Console.WriteLine("¿Desea más cartas? (s/n)");
                    continuar = Console.ReadLine();
                    carta = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta: " + carta);
                    Total += carta;
                    Console.WriteLine("Total de puntos: " + Total);
                }

                if (Total == 21)
                {
                    Console.WriteLine("GANASTE");
                    Console.WriteLine("Puntos totales: " + Total);
                }
                if (Total > 21)
                {
                    Console.WriteLine("PERDISTE");
                    Console.WriteLine("Puntos totales: " + Total);
                }              
            }

            if (continuar == "n")
            {
                Console.WriteLine("Te has retirado");
                Console.WriteLine("Puntos totales: " + Total);
            }
        }
    }
}
