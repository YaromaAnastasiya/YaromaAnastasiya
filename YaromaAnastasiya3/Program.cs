using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaromaAnastasiya3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int element = int.Parse(Console.ReadLine());
            int[]myArray = new int[element];
            


            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <myArray.Length; i++)
            {
                if (myArray[i]%3 == 0)
                {
                    Console.WriteLine(myArray[i]);
                }
                
            }
            Console.ReadLine();
            


        }
    }
}
