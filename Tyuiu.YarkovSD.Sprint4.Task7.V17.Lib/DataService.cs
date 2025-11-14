using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YarkovSD.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i * 3 + j].ToString());
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
