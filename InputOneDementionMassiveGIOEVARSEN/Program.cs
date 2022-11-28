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
            // ввод элементов массива в строку
            Console.WriteLine("введите количество измененией массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            string[] tempmas = Console.ReadLine().Split();

            for(int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(tempmas[i]);
            }

            foreach(var item in mas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Внимание, проверка на доступ из дома!");
            Console.WriteLine("Проверка 2");
        }
    }
}
