using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array1D_Operations
    {
        public static int SumOfEven()
        {
            int evenCount = 0;

            for (int i = 0; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] % 2 == 0)
                    evenCount += ArrayCreator.array1D[i];
            }

            return evenCount;
        }

        public static int SumOfOdd()
        {
            int oddCount = 0;

            for (int i = 0; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] % 2 != 0)
                    oddCount += ArrayCreator.array1D[i];
            }

            return oddCount;
        }

        public static int[] ReplaceMinAndMax()
        {
            int min = ArrayCreator.array1D.Min();
            int max = ArrayCreator.array1D.Max();

            int indexOfMin = Array.IndexOf(ArrayCreator.array1D, min);
            int indexOfMax = Array.IndexOf(ArrayCreator.array1D, max);

            ArrayCreator.array1D[indexOfMin] = max;
            ArrayCreator.array1D[indexOfMax] = min;

            return ArrayCreator.array1D;
        }

        public static int EvenMin()
        {
            int [] newMinArray = EvensArray();

            return newMinArray.Min();
        }

        public static int OddMax()
        {
            int[] newArray = new int[ArrayCreator.array1D.Length];

            for (int i = 0, j = 0; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] % 2 != 0)
                {
                    newArray[j] = ArrayCreator.array1D[i];
                    j++;
                }
            }

            return newArray.Max();
        }

        public static int[] SortFromMinToMAx()
        {
            Array.Sort(ArrayCreator.array1D);
            return ArrayCreator.array1D;
        }
        
        public static int[] SortFromMaxToMin()
        {
            SortFromMinToMAx();
            Array.Reverse(ArrayCreator.array1D);
            return ArrayCreator.array1D;
        }

        public static int[] SortFirstEvenThenOdd()
        {
            int[] newArray = new int[ArrayCreator.array1D.Length];

            for (int i = 0, j = 0, k = ArrayCreator.array1D.Length - 1; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] % 2 == 0)
                {
                    newArray[j] = ArrayCreator.array1D[i];
                    j++;
                }
                else
                {
                    newArray[k] = ArrayCreator.array1D[i];
                    k--;
                }
            }

            ArrayCreator.array1D = newArray;

            return ArrayCreator.array1D;
        }

        public static int[] EvensArray()
        {
            int[] newArray = new int[ArrayCreator.array1D.Length];

            int indexOfFirstZero = 0;

            for (int i = 0, j = 0; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] % 2 == 0)
                {
                    newArray[j] = ArrayCreator.array1D[i];
                    j++;
                }

                if (newArray[j] == 0)
                {
                    indexOfFirstZero = Array.IndexOf(newArray, newArray[j]);
                }
            }

            int[] newMinArray = new int[indexOfFirstZero];

            for (int i = 0; i < newMinArray.Length; i++)
            {
                newMinArray[i] = newArray[i];
            }

            return newMinArray;
        }

        public static int[] OddsArray()
        {
            int[] newArray = new int[ArrayCreator.array1D.Length];

            int indexOfFirstZero = 0;

            for (int i = 0, j = 0; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] % 2 != 0)
                {
                    newArray[j] = ArrayCreator.array1D[i];
                    j++;
                }

                if (newArray[j] == 0)
                {
                    indexOfFirstZero = Array.IndexOf(newArray, newArray[j]);
                }
            }

            int[] newMinArray = new int[indexOfFirstZero];

            for (int i = 0; i < newMinArray.Length; i++)
            {
                newMinArray[i] = newArray[i];
            }

            return newMinArray;
        }

        public static int[] ZeroIfBigger9()
        {
            for (int i = 0; i < ArrayCreator.array1D.Length; i++)
            {
                if (ArrayCreator.array1D[i] > 9)
                {
                    ArrayCreator.array1D[i] = 0;
                }
            }
            
            return ArrayCreator.array1D;
        }
    }

}
