using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class ArrayCreator
    {
        public static int[,] array2D = new int[0, 0];

        public static int[] array1D = new int[0];

        public static Random random = new Random();

        public static int[] CreateAndFill1DArray(int arrayLength)
        {
            array1D = new int[arrayLength];

            for (int i = 0; i < array1D.Length; i++)
                array1D[i] = random.Next(100);

            return array1D;
        }

        public static int[,] CreateAndFill2DArray(int arrayHeigh, int arrayLength)
        {
            array2D = new int[arrayHeigh, arrayLength];

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                    array2D[i, j] = random.Next(100);
            }

            return array2D;
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
            MessagesViewer.Write("\n");
            for (int i = 0; i < arrayRandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayRandomNumbers.GetLength(1); j++)
                    MessagesViewer.Write($"[{String.Format("{0:00}", arrayRandomNumbers[i, j])}] ");

                MessagesViewer.Write("\n");
            }
        }

        public static void Print1DArray(int[] arrayRandomNumbers)
        {
            MessagesViewer.Write("\n");

            for (int i = 0; i < arrayRandomNumbers.Length; i++)
                MessagesViewer.Write($"[{String.Format("{0:00}", arrayRandomNumbers[i])}] ");

            MessagesViewer.Write("\n");
        }
    }
}
