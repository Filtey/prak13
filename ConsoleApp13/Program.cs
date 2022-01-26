using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            while(true)
            {
                Console.WriteLine("\n1.Ввести А\n2.Ввести В\n3.Выполнить операцию -\n4.Выполнить операцию +\n5.Выполнить операцию *\n6.Выполнить операцию /");
                int vvod = int.Parse(Console.ReadLine());




                if (vvod == 3)
                {
                    Console.WriteLine(a - b);
                }












                Console.ReadKey();
                Console.Clear();
            }
           
        }
    }
}
