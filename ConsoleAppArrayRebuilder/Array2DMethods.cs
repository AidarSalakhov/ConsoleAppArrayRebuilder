using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array2DMethods
    {
        public static int[,] Replace1And3Lines(int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = newArray.GetLength(0) - 1, k = 0; i >= 0; i--, k++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                    resultArray[i, j] = newArray[k,j];
            }

            return resultArray;
        }

        public static int SumOfNumbersBiggerThen9(int[,] newArray)
        {
            int sumOfNumbers = 0;

            foreach (var item in newArray)
            {
                if (item > 9)
                    sumOfNumbers += item;
            }

            return sumOfNumbers;
        }

        public static int SumOfNumbersMultiple5(int[,] newArray)
        {
            int sumOfNumbers = 0;

            foreach (var item in newArray)
            {
                if (item % 5 == 0)
                    sumOfNumbers += item;
            }

            return sumOfNumbers;
        }

        public static int[,] Replace1And3Colums(int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = newArray.GetLength(1) - 1, k = 0; j >= 0; j--, k++)
                    resultArray[i, k] = newArray[i, j];
            }
                
            return resultArray;
        }

        public static int[,] ToZeroIfUnderMainDiagonal(int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int k = 0; k < i; k++)
                    resultArray[i, k] = 0;

                for (int j = i; j < newArray.GetLength(1); j++)
                    resultArray[i, j] = newArray[i, j];
            }

            return resultArray;
        }

        public static int[,] ToZeroIfAboveMainDiagonal(int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int k = 0; k <= i; k++)
                    resultArray[i, k] = newArray[i, k];

                for (int j = i + 1; j < newArray.GetLength(1); j++)
                    resultArray[i, j] = 0;
            }

            return resultArray;
        }

        public static int[,] ToZeroIfUnderSecondaryDiagonal(int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = 0, z = newArray.GetLength(1); i < newArray.GetLength(0); i++, z--)
            {
                for (int k = 0; k < z; k++)
                    resultArray[i, k] = newArray[i, k];

                for (int j = z; j < newArray.GetLength(1); j++)
                    resultArray[i, j] = 0;
            }

            return resultArray;
        }

        public static int[,] ToZeroIfAboveSecondaryDiagonal(int[,] newArray)
        {
            int[,] resultArray = new int[newArray.GetLength(0), newArray.GetLength(1)];

            for (int i = 0, z = newArray.GetLength(1) - 1; i < newArray.GetLength(0); i++, z--)
            {
                for (int k = 0; k < z; k++)
                    resultArray[i, k] = 0;
                
                for (int j = z; j < newArray.GetLength(1); j++)
                    resultArray[i, j] = newArray[i, j];
            }

            return resultArray;
        }
    }
}
