using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Array1DMethods
    {
        public static int SumOfEven(int[] newArray)
        {
            int evenCount = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 == 0)
                    evenCount += newArray[i];
            }

            return evenCount;
        }

        public static int SumOfOdd(int[] newArray)
        {
            int oddCount = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 != 0)
                    oddCount += newArray[i];
            }

            return oddCount;
        }

        public static int[] ReplaceMinAndMax(int[] newArray)
        {
            int min = newArray.Min();
            int max = newArray.Max();

            int indexOfMin = Array.IndexOf(newArray, min);
            int indexOfMax = Array.IndexOf(newArray, max);

            newArray[indexOfMin] = max;
            newArray[indexOfMax] = min;

            return newArray;
        }

        public static int EvenMin(int[] newArray)
        {
            newArray = CreateEvensArray(newArray);
            return newArray.Min();
        }

        public static int OddMax(int[] newArray)
        {
            int[] resultArray = new int[newArray.Length];

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 != 0)
                {
                    resultArray[j] = newArray[i];
                    j++;
                }
            }
            return resultArray.Max();
        }

        public static int[] SortFromMinToMax(int[] newArray)
        {
            Array.Sort(newArray);
            return newArray;
        }
        
        public static int[] SortFromMaxToMin(int[] newArray)
        {
            newArray = SortFromMinToMax(newArray);
            Array.Reverse(newArray);
            return newArray; 
        }

        public static int[] SortFirstEvenThenOdd(int[] newArray)
        {
            int[] resultArray = new int[newArray.Length];

            for (int i = 0, j = 0, k = resultArray.Length - 1; i < resultArray.Length; i++)
            {
                if (newArray[i] % 2 == 0)
                {
                    resultArray[j] = newArray[i];
                    j++;
                }
                else
                {
                    resultArray[k] = newArray[i];
                    k--;
                }
            }
            
            return resultArray;
        }

        public static int[] CreateEvensArray(int[] newArray)
        {
            int[] someArray = new int[newArray.Length];
            int indexOfFirstZero = 0;

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 == 0)
                {
                    someArray[j] = newArray[i];
                    j++;
                }

                if (someArray[j] == 0)
                    indexOfFirstZero = Array.IndexOf(someArray, someArray[j]);
            }

            int[] resultArray = new int[indexOfFirstZero];

            for (int i = 0; i < resultArray.Length; i++)
                resultArray[i] = someArray[i];

            return resultArray;
        }

        public static int[] CreateOddsArray(int[] newArray)
        {
            int[] someArray = new int[newArray.Length];
            int indexOfFirstZero = 0;

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 != 0)
                {
                    someArray[j] = newArray[i];
                    j++;
                }

                if (someArray[j] == 0)
                    indexOfFirstZero = Array.IndexOf(someArray, someArray[j]);
            }

            int[] resultArray = new int[indexOfFirstZero];

            for (int i = 0; i < resultArray.Length; i++)
                resultArray[i] = someArray[i];

            return resultArray;
        }

        public static int[] ToZeroIfBiggerThen9(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] > 9)
                    newArray[i] = 0;
            }
            return newArray;
        }
    }

}
