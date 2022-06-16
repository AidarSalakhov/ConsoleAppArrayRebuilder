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
                if (ArrayCreator.array1D[i]%2 == 0)
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
    }
}
