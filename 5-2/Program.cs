using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input> ");
            int myInt = Convert.ToInt32(Console.ReadLine());
            if (myInt > 100)
            {
                Console.WriteLine("Too Large");
            }
            else
            {
                if (myInt % 2 == 0)
                {
                    
                    if (myInt % 10 == 0)
                    {
                        
                        if (myInt == 0)
                        {
                            Console.WriteLine("Equal to 0");
                        }
                        else Console.WriteLine("Multiple of 10");
                    }
                    else Console.WriteLine("even");
                }
                else Console.WriteLine("odd");
            }
        }
    }
}
