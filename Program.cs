using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {


        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            //call by reference;
            swap(ref x, ref y);
            // call by  value;
            swap(ref x, ref y);
            Console.WriteLine($"x:{x}.y:{y}");
            Console.ReadKey();
        }
        
            
        public static void swap (int x , int y)
        {
            int temp = 0;
            //put x to temp
            temp = x;
            //overwrite x
            x = y;
            //overwrite y
            y = temp;
            
        }

        
    }
}

