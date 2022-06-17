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

        public static int SumOfNumbersBiggerThen9()
        {
            int sumOfNumbers = 0;

            foreach (var item in ArrayCreator.array2D)
            {
                if (item > 9)
                    sumOfNumbers += item;
            }

            return sumOfNumbers;
        }

        public static int SumOfNumbersMultiple5()
        {
            int sumOfNumbers = 0;

            foreach (var item in ArrayCreator.array2D)
            {
                if (item % 5 == 0)
                    sumOfNumbers += item;
            }

            return sumOfNumbers;
        }

        public static int[,] Replace1And3Colums()
        {
            int[,] newArray = new int[ArrayCreator.array2D.GetLength(0), ArrayCreator.array2D.GetLength(1)];

            for (int i = 0; i < ArrayCreator.array2D.GetLength(0); i++)
            {
                for (int j = ArrayCreator.array2D.GetLength(1) - 1, k = 0; j >= 0; j--, k++)
                    newArray[i, k] = ArrayCreator.array2D[i, j];
            }
                
            ArrayCreator.array2D = newArray;
            return ArrayCreator.array2D;
        }
    }
}
