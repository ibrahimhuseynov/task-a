using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soz = Console.ReadLine();
            int say = 0;
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == 'a')
                {
                    say++;
                    
                }
            }
            Console.WriteLine(say);
            Console.ReadLine();
        }
    }
}
