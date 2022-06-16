using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class ArrayCreator
    {
        public static int[,] array2DRandomNumbers = new int[0, 0];

        public static int[] array1DRandomNumbers = new int[0];

        public static Random random = new Random();

        public static int[] CreateAndFill1DArray(int arrayLength)
        {
            array1DRandomNumbers = new int[arrayLength];

            for (int i = 0; i < array1DRandomNumbers.Length; i++)
                array1DRandomNumbers[i] = random.Next(100);

            return array1DRandomNumbers;
        }

        public static int[,] CreateAndFill2DArray(int arrayHeigh, int arrayLength)
        {
            array2DRandomNumbers = new int[arrayHeigh, arrayLength];

            for (int i = 0; i < array2DRandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < array2DRandomNumbers.GetLength(1); j++)
                    array2DRandomNumbers[i, j] = random.Next(100);
            }

            return array2DRandomNumbers;
        }

        public static int[,] Create2DSuperArray()
        {
            MessagesViewer.Info(Messages.INFO_ENTER_ARRAY_HEIGH);
            int arrayHeigh = Convert.ToInt32(Console.ReadLine());
            MessagesViewer.Info(Messages.INFO_ENTER_ARRAY_LENGTH);
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            return CreateAndFill2DArray(arrayHeigh, arrayLength);
        }

        public static void Print2DArray(int[,] arrayRandomNumbers)
        {
            for (int i = 0; i < arrayRandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayRandomNumbers.GetLength(1); j++)
                    MessagesViewer.Default($"[{String.Format("{0:00}", arrayRandomNumbers[i, j])}] ");

                MessagesViewer.Default("\n");
            }
        }

        public static void Print1DArray(int[] arrayRandomNumbers)
        {
            for (int i = 0; i < arrayRandomNumbers.Length; i++)
                MessagesViewer.Default($"[{String.Format("{0:00}", arrayRandomNumbers[i])}] ");

            MessagesViewer.Default("\n");
        }


    }
}
