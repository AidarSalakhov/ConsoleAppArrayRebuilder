using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class ArrayCreator
    {
        
        public static int[,] arrayRandomNumbers = new int[0, 0];

        public static int[,] CreateAndFillArray(int arrayHeigh, int arrayLength)
        {
            arrayRandomNumbers = new int[arrayHeigh, arrayLength];

            Random random = new Random();

            for (int i = 0; i < arrayRandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayRandomNumbers.GetLength(1); j++)
                {
                    arrayRandomNumbers[i, j] = random.Next(100);
                }
            }

            return arrayRandomNumbers;
        }

        public static void PrintArray(int[,] arrayRandomNumbers)
        {
            for (int i = 0; i < arrayRandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayRandomNumbers.GetLength(1); j++)
                {
                    MessagesViewer.Default($"[{String.Format("{0:00}", arrayRandomNumbers[i,j])}] ");
                }

                MessagesViewer.Default("\n");
            }
        }

        public static int[,] CreateCustomArray()
        {
            MessagesViewer.Info(Messages.INFO_ENTER_ARRAY_HEIGH);

            int arrayHeigh = Convert.ToInt32(Console.ReadLine());
                
            MessagesViewer.Info(Messages.INFO_ENTER_ARRAY_LENGTH);

            int arrayLength = Convert.ToInt32(Console.ReadLine());

            return CreateAndFillArray(arrayHeigh, arrayLength);
        }
    }
}
