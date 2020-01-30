using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de SMMLV:");
            double SMMLV = double.Parse(Console.ReadLine());

            if (SMMLV < 2)
            {
                Console.WriteLine("Su cuota moredadora tipo A es de: $3.400");
            }else if (2 == SMMLV && SMMLV < 5)
            {
                Console.WriteLine("Su cuota moredadora tipo B es de: $13.500");
            }
            else if (SMMLV >= 5)
            {
                Console.WriteLine("Su cuota moredadora tipo C es de: $35.600");
            }
        }
    }
}
