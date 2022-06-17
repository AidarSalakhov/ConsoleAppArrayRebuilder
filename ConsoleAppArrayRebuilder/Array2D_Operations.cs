using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array2D_Operations
    {
        public static int[,] Replace1And3Lines()
        {
            int[,] newArray = new int[ArrayCreator.array2D.GetLength(0), ArrayCreator.array2D.GetLength(1)];

            for (int i = ArrayCreator.array2D.GetLength(0) - 1, k = 0; i >= 0; i--, k++)
            {
                for (int j = 0; j < ArrayCreator.array2D.GetLength(1); j++)
                    newArray[i, j] = ArrayCreator.array2D[k,j];
            }

            ArrayCreator.array2D = newArray;
            return ArrayCreator.array2D;
        }
    }
}
