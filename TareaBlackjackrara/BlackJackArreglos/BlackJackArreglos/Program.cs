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
            int n = 0;
            int i = 0;
            string nombrr = "";
            string continuar = "s";
            int puntajeMAX = 0;
            int puntajeMIN = 100;
            string nombreMAX = "";
            string nombreMIN = "";

            Console.WriteLine("Ingrese el número de jugadores (2-5)");
            n = int.Parse(Console.ReadLine());
            while (n <= 1 || n > 5)
            {
                Console.WriteLine("Ingrese un número de jugadores Valido (2-5)");
                n = int.Parse(Console.ReadLine());
            }

            string[] nombres = new string[n];
            int[] puntajes = new int[n];

            for (i = 0; i < n; i++)
            {
                continuar = "s";
                Total = 0;

                while (continuar == "s" && Total < 21)
                {

                    if (Total == 0)
                    {
                        Console.WriteLine("Bienvenido jugador " + (i + 1));
                        Console.WriteLine("Ingrese su nombre jugador " + (i + 1));
                        nombrr = Console.ReadLine();
                        nombres[i] = nombrr;
                        carta1 = aleatorio.Next(1, 11);
                        carta2 = aleatorio.Next(1, 11);
                        Total = carta1 + carta2;
                        Console.WriteLine("Carta 1: " + carta1);
                        Console.WriteLine("Carta 2: " + carta2);
                        Console.WriteLine("Total de puntos: " + Total);

                    }
                    
                    else if (Total < 21 && continuar == "s")
                    {
                       

                        while (continuar != "s" && continuar != "n")
                        {
                            Console.WriteLine("Ingrese una respuesta valida (s/n)");
                            continuar = Console.ReadLine();
                        }
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
                        puntajes[i] = 0;
                        Console.WriteLine("PERDISTE");
                        Console.WriteLine("Puntos totales: " + Total);

                    }
                    else
                    {
                        puntajes[i] = Total;
                        Console.WriteLine("¿Desea más cartas? (s/n)");
                        continuar = Console.ReadLine();
                    }
                   

                }

                

                if (Total > puntajeMAX)
                {
                    puntajeMAX = puntajes[i];
                    nombreMAX = nombres[i];
                }

                if (Total < puntajeMIN)
                {
                    puntajeMIN = puntajes[i];
                    nombreMIN = nombres[i];
                }

                if (continuar == "n")
                {
                    Console.WriteLine("Te has retirado");
                    Console.WriteLine("Puntos totales: " + Total);
                }

               
                
            }

            Console.WriteLine("El puntaje mayor fue de " + nombreMAX + " con " + puntajeMAX);
            Console.WriteLine("El puntaje menor fue de " + nombreMIN + " con " + puntajeMIN);

        }
    }
}
