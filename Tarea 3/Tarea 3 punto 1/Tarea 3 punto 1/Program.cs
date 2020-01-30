using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de SMMLV: ");
            double SMMLV = double.Parse(Console.ReadLine());

            if ( SMMLV < 2)
            {
                Console.WriteLine("Le aplcia la tarifa A");
            }else if (2 == SMMLV && SMMLV < 4)
            {
                Console.WriteLine("Le aplcia la tarifa B");
            }else if (SMMLV >= 4)
            {
                Console.WriteLine("Le aplcia la tarifa C");
            }
        }
    }
}
