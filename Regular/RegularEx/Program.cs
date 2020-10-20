using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (string item in str.IP())
                Console.WriteLine("Ip: {0}", item);

            Console.WriteLine("\n\n\n");

            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (string item in str.GUID())
                Console.WriteLine("GUID: {0}", item);
            Console.WriteLine("\n\n\n");

            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (string item in str.URL())
                Console.WriteLine("URL: {0}", item);
            Console.WriteLine("\n\n\n");

            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (string item in str.DATA())
                Console.WriteLine("DATA: {0}", item);
            Console.WriteLine("\n\n\n");

            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (string item in str.RUB())
                Console.WriteLine("RUB: {0}", item);
            Console.WriteLine("\n\n\n");
            
            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (string item in str.PAS())
                Console.WriteLine("PAS: {0}", item);
            Console.WriteLine("\n\n\n");

            Console.ReadKey();

        }
    }
}
