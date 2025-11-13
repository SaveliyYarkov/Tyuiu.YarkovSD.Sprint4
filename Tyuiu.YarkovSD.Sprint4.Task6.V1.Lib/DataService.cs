using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YarkovSD.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 6)
                {
                    a++;
                }
            }
            return a;
        }
    }
}
