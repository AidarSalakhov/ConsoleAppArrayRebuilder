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
            int[] newArray = new int[ArrayCreator.array1D.Length];
            Array.Copy(ArrayCreator.array1D, newArray, newArray.Length);

            int min = newArray.Min();
            int max = newArray.Max();

            int indexOfMin = Array.IndexOf(newArray, min);
            int indexOfMax = Array.IndexOf(newArray, max);

            newArray[indexOfMin] = max;
            newArray[indexOfMax] = min;

            return newArray;
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
            int[] newArray = new int[ArrayCreator.array1D.Length];
            Array.Copy(ArrayCreator.array1D, newArray, newArray.Length);
            Array.Sort(newArray);
            return newArray;
        }
        
        public static int[] SortFromMaxToMin()
        {
            int[] newArray = SortFromMinToMax();
            Array.Reverse(newArray);
            return newArray; 
        }

        public static int[] SortFirstEvenThenOdd()
        {
            int[] newArray = new int[ArrayCreator.array1DAfterMethodWork.Length];

            for (int i = 0, j = 0, k = newArray.Length - 1; i < newArray.Length; i++)
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
            
            return newArray;
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
            int[] newArray = new int[ArrayCreator.array1D.Length];
            Array.Copy(ArrayCreator.array1D, newArray, newArray.Length);

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] > 9)
                    newArray[i] = 0;
            }
            return newArray;
        }
    }

}
