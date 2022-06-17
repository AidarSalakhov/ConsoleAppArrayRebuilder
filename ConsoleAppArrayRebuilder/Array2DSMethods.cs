using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array2DSMethods
    {
        public static int[,] ToZeroAboveMainDiagonalIfLowerThanX(int x)
        {
            int[,] newArray = new int[ArrayCreator.array2D.GetLength(0), ArrayCreator.array2D.GetLength(1)];

            for (int i = 0; i < ArrayCreator.array2D.GetLength(0); i++)
            {
                for (int k = 0; k <= i; k++)
                    newArray[i, k] = ArrayCreator.array2D[i, k];

                for (int j = i + 1; j < ArrayCreator.array2D.GetLength(1); j++)
                {
                    if (ArrayCreator.array2D[i,j] < x)
                        newArray[i, j] = 0;
                    else
                        newArray[i, j] = ArrayCreator.array2D[i, j];
                }
            }

            ArrayCreator.array2D = newArray;
            return ArrayCreator.array2D;
        }
    }
}
