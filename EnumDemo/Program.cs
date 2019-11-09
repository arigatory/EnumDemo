using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D c = new Vector3D
            {
                X = 34, Y = 4, Z = 243
            };

            foreach (double coordinate in c)
            {
                Console.WriteLine(coordinate);
            }

            Console.WriteLine();

            foreach (int item in Odd())
            {
                Console.WriteLine(item);
                if (Console.KeyAvailable)
                {
                    break;
                }
            }

            Console.ReadLine();
        }

        static IEnumerable<int> Odd()
        {
            for (int i = 1; i <= int.MaxValue; i=i+2)
            {
                yield return i;
            }
            
        }
    }
}
 