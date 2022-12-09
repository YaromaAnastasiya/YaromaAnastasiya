using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaromaAnastasiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string number = Console.ReadLine();
            int number_1 = Convert.ToInt32(number);
            if (number_1 > 7)
            {

                Console.WriteLine("привет");
            }
        }
    }
}
