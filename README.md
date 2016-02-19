using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            int i;
            Random random = new Random();
            int x = random.Next(1, 1000);
            for (i = 0; i < 3; i++)
            {
                Console.Write("Введите ваш вариант");
                y = Convert.ToInt32(Console.ReadLine());
                if (x < y)
                {
                    Console.WriteLine("Введенное число больше загаданного");
                }
                if (x > y)
                {
                    Console.WriteLine("Введенное число меньше загаданного");
                }
                if (x == y)
                {
                    Console.WriteLine("ЧЕМПИОН!!!");
                }          
            }
            Console.ReadKey();
        }
    }
}
