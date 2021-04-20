using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraLibrary.Validaciones
{
    public class Validaciones
    {
        public static int validarInt()
        {
            int numero;

            String input = Console.ReadLine();

            while (!Int32.TryParse(input, out numero))
            {
                Console.WriteLine("Numero invalido, intente nuevamente.");

                input = Console.ReadLine();
            }
            return numero;
        }

        public static long validarLong()
        {
            long numero;

            String input = Console.ReadLine();

            while (!long.TryParse(input, out numero))
            {
                Console.WriteLine("Numero invalido, intente nuevamente.");

                input = Console.ReadLine();
            }
            return numero;
        }

        public static double validarDouble()
        {
            double numero;

            String input = Console.ReadLine();

            while (!double.TryParse(input, out numero))
            {
                Console.WriteLine("Numero invalido, intente nuevamente.");

                input = Console.ReadLine();
            }
            return numero;
        }


    }
}
