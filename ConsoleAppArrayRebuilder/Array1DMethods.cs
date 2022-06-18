using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array1DMethods
    {
        public static int SumOfEven()
        {
            int evenCount = 0;

            for (int i = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] % 2 == 0)
                    evenCount += ArrayCreator.array1DAfterMethodWork[i];
            }

            return evenCount;
        }

        public static int SumOfOdd()
        {
            int oddCount = 0;

            for (int i = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] % 2 != 0)
                    oddCount += ArrayCreator.array1DAfterMethodWork[i];
            }

            return oddCount;
        }

        public static int[] ReplaceMinAndMax()
        {
            int min = ArrayCreator.array1DAfterMethodWork.Min();
            int max = ArrayCreator.array1DAfterMethodWork.Max();

            int indexOfMin = Array.IndexOf(ArrayCreator.array1DAfterMethodWork, min);
            int indexOfMax = Array.IndexOf(ArrayCreator.array1DAfterMethodWork, max);

            ArrayCreator.array1DAfterMethodWork[indexOfMin] = max;
            ArrayCreator.array1DAfterMethodWork[indexOfMax] = min;

            return ArrayCreator.array1DAfterMethodWork;
        }

        public static int EvenMin()
        {
            int [] newMinArray = CreateEvensArray();
            return newMinArray.Min();
        }

        public static int OddMax()
        {
            int[] newArray = new int[ArrayCreator.array1DAfterMethodWork.Length];

            for (int i = 0, j = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] % 2 != 0)
                {
                    newArray[j] = ArrayCreator.array1DAfterMethodWork[i];
                    j++;
                }
            }
            return newArray.Max();
        }

        public static int[] SortFromMinToMax()
        {
            Array.Sort(ArrayCreator.array1DAfterMethodWork);
            return ArrayCreator.array1DAfterMethodWork;
        }
        
        public static int[] SortFromMaxToMin()
        {
            SortFromMinToMax();
            Array.Reverse(ArrayCreator.array1DAfterMethodWork);
            return ArrayCreator.array1DAfterMethodWork;
        }

        public static int[] SortFirstEvenThenOdd()
        {
            int[] newArray = new int[ArrayCreator.array1DAfterMethodWork.Length];

            for (int i = 0, j = 0, k = ArrayCreator.array1DAfterMethodWork.Length - 1; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] % 2 == 0)
                {
                    newArray[j] = ArrayCreator.array1DAfterMethodWork[i];
                    j++;
                }
                else
                {
                    newArray[k] = ArrayCreator.array1DAfterMethodWork[i];
                    k--;
                }
            }
            ArrayCreator.array1DAfterMethodWork = newArray;
            return ArrayCreator.array1DAfterMethodWork;
        }

        public static int[] CreateEvensArray()
        {
            int[] newArray = new int[ArrayCreator.array1DAfterMethodWork.Length];
            int indexOfFirstZero = 0;

            for (int i = 0, j = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] % 2 == 0)
                {
                    newArray[j] = ArrayCreator.array1DAfterMethodWork[i];
                    j++;
                }

                if (newArray[j] == 0)
                    indexOfFirstZero = Array.IndexOf(newArray, newArray[j]);
            }

            int[] newMinArray = new int[indexOfFirstZero];

            for (int i = 0; i < newMinArray.Length; i++)
                newMinArray[i] = newArray[i];

            return newMinArray;
        }

        public static int[] CreateOddsArray()
        {
            int[] newArray = new int[ArrayCreator.array1DAfterMethodWork.Length];
            int indexOfFirstZero = 0;

            for (int i = 0, j = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] % 2 != 0)
                {
                    newArray[j] = ArrayCreator.array1DAfterMethodWork[i];
                    j++;
                }

                if (newArray[j] == 0)
                    indexOfFirstZero = Array.IndexOf(newArray, newArray[j]);
            }

            int[] newMinArray = new int[indexOfFirstZero];

            for (int i = 0; i < newMinArray.Length; i++)
                newMinArray[i] = newArray[i];

            return newMinArray;
        }

        public static int[] ToZeroIfBiggerThen9()
        {
            for (int i = 0; i < ArrayCreator.array1DAfterMethodWork.Length; i++)
            {
                if (ArrayCreator.array1DAfterMethodWork[i] > 9)
                    ArrayCreator.array1DAfterMethodWork[i] = 0;
            }
            return ArrayCreator.array1DAfterMethodWork;
        }
    }

}
