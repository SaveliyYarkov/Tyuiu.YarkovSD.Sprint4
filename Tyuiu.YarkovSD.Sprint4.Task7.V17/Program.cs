using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YarkovSD.Sprint4.Task7.V17.Lib;

namespace Tyuiu.YarkovSD.Sprint4.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "753159864";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[index].ToString());
                    Console.Write($"{mtrx[i, j]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Количество четных элементов массива равна: " + res);
            Console.ReadKey();
        }
    }
}