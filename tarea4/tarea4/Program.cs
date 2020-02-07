using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de votos por el partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos por el partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Población de todas las edades");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de la población mayor de edad");
            int p = int.Parse(Console.ReadLine());

            int mayores = n * p / 100;
            int Total = a + b + blancos + anulados;
            int diferencia = 0;

            if (a > b)
            {
                diferencia = a - b;
            }
            else
            {
                diferencia = b - a;
            }

            int diezpor = Total * 10 / 100;
            int trintapo = n * 30 / 100;

            bool condicion1 = (Total > n);
            bool condicion2 = (diferencia<diezpor);
            bool condicion3 = (Total < trintapo);

            if((condicion1||condicion2) && condicion3)
            {
                Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("El ganador es el partido 2");
                }
                else
                {
                    Console.WriteLine("El ganador es el partido 1");
                }
            }
        }
    }
}
