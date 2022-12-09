using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaromaAnastasiya2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            if (name == "Вячеслав")
            {
                Console.WriteLine("Привет Вячеслав");
            }
            else
            {
                Console.WriteLine("нет такого имени");
            }
            Console.ReadLine();
        }
    }
}
