using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class ArrayCreator
    {
        public static int[,] CreateArray(int heigh, int length)
        {
            Random random = new Random();

            int[,] array = new int[heigh,length];

            for (int i = 0; i < heigh; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            return array;
        }
    }
}
