using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_building_block
{
    public class Statements
    {
        int edad = Convert.ToInt32(Console.ReadLine());
        public void Comprobacion()
        {
            if(edad >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }

            switch (edad)
            {
                case 18:
                    Console.WriteLine("Mayor de edad");
                    break;

                default:
                    Console.WriteLine("Menor de edad");
                    break;
            }
        }

        public void Tabla()
        {
            string continuar;
            do
            {
                Console.WriteLine("Introduzca un numero");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La tabla de multiplicar de: " + num + " es ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + "*" + i + "= " + num * i);
                }
                Console.WriteLine("Desea ver otra tabla? (si/no?)");
                continuar = Console.ReadLine();
            } while (continuar == "si");
            if (continuar == "no")
            {
                Console.WriteLine("Adios!");
            }
            Console.ReadKey();
        }
    }
}
