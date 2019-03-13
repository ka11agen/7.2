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
            int[] a = new int[5];
            int[] b = new int[5];
            string buf;
            Console.WriteLine("Предмет: Математика");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Оценки ученика под номером {0}", i + 1);
                buf = Console.ReadLine();
                a[i] = Convert.ToInt32(buf);
            }
            Console.WriteLine("Предмет: Информатика");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Оценки ученика под номером {0}", i + 1);
                buf = Console.ReadLine();
                b[i] = Convert.ToInt32(buf);
            }
            double c = 0, d = 0;
            foreach (int x in a) c = c + x;
            c = c / 5;
            foreach (int x in b) d = d + x;
            d = d / 5;
            Console.WriteLine("Средний бал по Математике = {0}", c);
            Console.WriteLine("Средний бал по Информатике = {0}", d);
            Console.ReadLine();
        }
    }
}
