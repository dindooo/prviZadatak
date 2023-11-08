using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            upis: Console.WriteLine("Upisite stranicu x pravokutnog trokuta");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite stranicu y pravokutnog trokuta");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite hipotenuzu z pravokutnog trokuta");
            z = Convert.ToInt32(Console.ReadLine());
            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Upisali ste nevazece dimenzije");
                goto upis;
            }
            if(z*z==x*x+y*y)
            {
                Console.WriteLine("Trokut je pravokutan");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan");
            }
            Console.ReadKey();

        }
    }
    
}
