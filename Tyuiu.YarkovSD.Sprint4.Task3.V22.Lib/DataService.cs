using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YarkovSD.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int m = -9999;

            for (int i = 0; i < array.GetLength(0); i++)
                    for (int j = 0; j < array.GetLength(0); j++)
                        if (array[0, j] > m)
                            m = array[i, j];
            return m;
        }
    }
}
