using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array2DSMethods
    {
        public static int[,] ToZeroAboveMainDiagonalIfLowerThanX(int x, int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int k = 0; k <= i; k++)
                    resultArray[i, k] = newArray[i, k];

                for (int j = i + 1; j < newArray.GetLength(1); j++)
                {
                    if (newArray[i,j] < x)
                        resultArray[i, j] = 0;
                    else
                        resultArray[i, j] = newArray[i, j];
                }
            }

            return resultArray;
        }

        public static int[] AboveSecondaryDiagonalLowerThanXToArray(int x, int[,] newArray)
        {
            int[,] result2DArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            List<int> list = new List<int>();

            for (int i = 0, z = newArray.GetLength(1) - 1; i < newArray.GetLength(0); i++, z--)
            {
                for (int k = 0; k < z; k++)
                {
                    if (newArray[i, k] < x)
                        list.Add(newArray[i,k]);
                }  

                for (int j = z; j < newArray.GetLength(1); j++)
                    result2DArray[i, j] = newArray[i, j];
            }

            int[] resultArray = new int[list.Count];

            for (int i = 0; i < resultArray.Length; i++)
                resultArray[i] = list[i];
            
            return resultArray;
        }
    }
}
