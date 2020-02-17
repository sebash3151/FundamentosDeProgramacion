using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int Dado = 0;
            int Total = 0;
            int turnos = 0;
            string respuesta = "s";
            bool Combo = false;
            
            Console.WriteLine("Bienvenido a los juegos del hambre");

            while (respuesta == "s"&& Total < 100)
            {
                if (Total == 0)
                {
                    Dado = aleatorio.Next(1, 13);
                    Console.WriteLine("Dado: " + Dado);
                    Total += Dado;
                    Console.WriteLine("Puntos Actuales: " + Total);
                    turnos++;
                    Console.WriteLine("Turno Actual: " + turnos);
                }

                if (Total > 0)
                {
                    Console.WriteLine("¿Desea seguir jugando? (s/n)");
                    respuesta = Console.ReadLine();
                    //Dado = aleatorio.Next(1, 13);
                    Dado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dado: " + Dado);
                    Total += Dado;
                    Console.WriteLine("Puntos Actuales: " + Total);
                    turnos++;
                    Console.WriteLine("Turno Actual: " + turnos);               
                }

                if (turnos > 3)
                {
                    if (Dado == 1 || Dado == 3 || Dado == 5 || Dado == 7 || Dado == 9 || Dado == 11)
                    {
                        respuesta = "per";
                    }
                }

                if (Dado == 12)
                {
                    Combo = true;
                }

                if (Combo == true && Dado == 10)
                {
                    respuesta = "combo";
                }

            }

            if (Total >= 100)
            {
                Console.WriteLine("HAS GANADO");
                Console.WriteLine("Puntos Totales: " + Total);
                Console.WriteLine("Turno Final: " + turnos);
            }

            if (respuesta == "n")
            {
                Console.WriteLine("¿Te retiras cobarde?");
                Console.WriteLine("Puntos Totales: " + Total);
                Console.WriteLine("Turno Final: " + turnos);
            }

            if (respuesta == "per")
            {
                Console.WriteLine("PERDISTE ERES UN FRACASO");
                Console.WriteLine("Puntos Totales: " + Total);
                Console.WriteLine("Turno Final: " + turnos);
            }

            if (respuesta == "combo")
            {
                Console.WriteLine("COMBO 12 + 10");
                Console.WriteLine("Puntos Totales: " + Total);
                Console.WriteLine("Turno Final: " + turnos);
            }
        }
    }
}
