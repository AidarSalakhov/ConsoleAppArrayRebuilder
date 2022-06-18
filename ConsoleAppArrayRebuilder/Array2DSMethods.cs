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
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = 0; i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++)
            {
                for (int k = 0; k <= i; k++)
                    newArray[i, k] = ArrayCreator.array2DAfterMethodWork[i, k];

                for (int j = i + 1; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                {
                    if (ArrayCreator.array2DAfterMethodWork[i,j] < x)
                        newArray[i, j] = 0;
                    else
                        newArray[i, j] = ArrayCreator.array2DAfterMethodWork[i, j];
                }
            }

            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }

        public static int[] AboveSecondaryDiagonalLowerThanXToArray(int x)
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            List<int> list = new List<int>();

            for (int i = 0, z = ArrayCreator.array2DAfterMethodWork.GetLength(1) - 1; i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++, z--)
            {
                for (int k = 0; k < z; k++)
                {
                    if (ArrayCreator.array2DAfterMethodWork[i, k] < x)
                        list.Add(ArrayCreator.array2DAfterMethodWork[i,k]);
                }  

                for (int j = z; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                    newArray[i, j] = ArrayCreator.array2DAfterMethodWork[i, j];
            }

            ArrayCreator.CreateAndFill1DArray(list.Count);

            for (int i = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
                ArrayCreator.array1DAfterMethodWork[i] = list[i];
            
            return ArrayCreator.array1DAfterMethodWork;
        }
    }
}
