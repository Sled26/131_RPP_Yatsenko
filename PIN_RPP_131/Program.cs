using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 6;
            int z = x + y;
            Console.WriteLine(z);
            if (z > 0)
            {
                Console.WriteLine("Больше нуля");
            }
            else
            {
                Console.WriteLine("Меньше нуля");
            }
            if (z % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не четное");
            }
            if (z % 5 == 0)
            {
                Console.WriteLine("Делится на 5");
            }
            else
            {
                Console.WriteLine("Не делится на 5");
            }
            if (z % 10 == 0)
            {
                Console.WriteLine("Делится на 10");
            }
            else
            {
                Console.WriteLine("Не делится на 10");
            }
            if (z % 20 == 0)
            {
                Console.WriteLine("Делится на 20");
            }
            else
            {
                Console.WriteLine("Не делится на 20");
            }
        Start:
            if (z >= 0)
            {
                Console.WriteLine(z--);
                goto Start;
            }

            Console.Write(z = z + 10);
        Start2:
            if (z >= 0)
            {
                Console.WriteLine(--z);
                goto Start2;
            }
            Console.Write(z = z + 10);
            while (z >= 0)
            {
                Console.WriteLine(--z);
            }
            Console.Write(z = z + 10);
            do
            {
                Console.WriteLine(z--);
            } while (z >= 0);

        }
    }
}
