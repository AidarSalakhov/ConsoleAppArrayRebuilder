﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array2DMethods
    {
        public static int[,] Replace1And3Lines()
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = ArrayCreator.array2DAfterMethodWork.GetLength(0) - 1, k = 0; i >= 0; i--, k++)
            {
                for (int j = 0; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                    newArray[i, j] = ArrayCreator.array2DAfterMethodWork[k,j];
            }

            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }

        public static int SumOfNumbersBiggerThen9()
        {
            int sumOfNumbers = 0;

            foreach (var item in ArrayCreator.array2DAfterMethodWork)
            {
                if (item > 9)
                    sumOfNumbers += item;
            }

            return sumOfNumbers;
        }

        public static int SumOfNumbersMultiple5()
        {
            int sumOfNumbers = 0;

            foreach (var item in ArrayCreator.array2DAfterMethodWork)
            {
                if (item % 5 == 0)
                    sumOfNumbers += item;
            }

            return sumOfNumbers;
        }

        public static int[,] Replace1And3Colums()
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = 0; i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++)
            {
                for (int j = ArrayCreator.array2DAfterMethodWork.GetLength(1) - 1, k = 0; j >= 0; j--, k++)
                    newArray[i, k] = ArrayCreator.array2DAfterMethodWork[i, j];
            }
                
            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }

        public static int[,] ToZeroIfUnderMainDiagonal()
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = 0; i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++)
            {
                for (int k = 0; k < i; k++)
                    newArray[i, k] = 0;

                for (int j = i; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                    newArray[i, j] = ArrayCreator.array2DAfterMethodWork[i, j];
            }
            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }

        public static int[,] ToZeroIfAboveMainDiagonal()
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = 0; i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++)
            {
                for (int k = 0; k <= i; k++)
                    newArray[i, k] = ArrayCreator.array2DAfterMethodWork[i, k];

                for (int j = i + 1; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                    newArray[i, j] = 0;
            }

            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }

        public static int[,] ToZeroIfUnderSecondaryDiagonal()
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = 0, z = ArrayCreator.array2DAfterMethodWork.GetLength(1); i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++, z--)
            {
                for (int k = 0; k < z; k++)
                    newArray[i, k] = ArrayCreator.array2DAfterMethodWork[i, k];

                for (int j = z; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                    newArray[i, j] = 0;
            }

            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }

        public static int[,] ToZeroIfAboveSecondaryDiagonal()
        {
            int[,] newArray = new int[ArrayCreator.array2DAfterMethodWork.GetLength(0), ArrayCreator.array2DAfterMethodWork.GetLength(1)];

            for (int i = 0, z = ArrayCreator.array2DAfterMethodWork.GetLength(1) - 1; i < ArrayCreator.array2DAfterMethodWork.GetLength(0); i++, z--)
            {
                for (int k = 0; k < z; k++)
                    newArray[i, k] = 0;
                
                for (int j = z; j < ArrayCreator.array2DAfterMethodWork.GetLength(1); j++)
                    newArray[i, j] = ArrayCreator.array2DAfterMethodWork[i, j];
            }

            ArrayCreator.array2DAfterMethodWork = newArray;
            return ArrayCreator.array2DAfterMethodWork;
        }
    }
}
