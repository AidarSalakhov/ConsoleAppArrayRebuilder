using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class ArrayCreator
    {
        
        public static int arrayHeigh;
        public static int arrayLength;
        public static int[,] arrayRandomNumbers = new int[arrayHeigh, arrayLength];


        public static int[,] CreateAndFillArray()
        {
            Random random = new Random();

            for (int i = 0; i < arrayHeigh; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    arrayRandomNumbers[i, j] = random.Next(100);
                }
            }

            return arrayRandomNumbers;
        }

        public static void PrintArray()
        {
            for (int i = 0; i < arrayHeigh; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    MessagesViewer.Default(Convert.ToString(arrayRandomNumbers[i,j]));
                }
            }
        }
    }
}
