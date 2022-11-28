using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOneDementionMassiveGIOEVARSEN
{
    class Program
    {
        static void Main(string[] args)
        {
            // константный массив
            int[] mas = { 5, 6, 8, 2, 8, 9 };

            foreach(var item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
