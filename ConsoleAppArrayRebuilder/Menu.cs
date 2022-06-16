using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppArrayRebuilder
{
    internal class Menu
    {
        public static void ShowMainMenu()
        {
            MessagesViewer.ShowMenuText();

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.O:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.CreateAndFill1DArray(5));
                    Show1DMenu();
                    break;

                case ConsoleKey.T:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.CreateAndFill2DArray(3, 3));
                    break;

                case ConsoleKey.N:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.Create2DSuperArray());
                    break;

                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error(Messages.ERROR_WRONG_BUTTON);
                    break;
            }
            ShowMainMenu();
        }

        public static void Show1DMenu()
        {
            MessagesViewer.Show1DMenuText();

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    MessagesViewer.WriteLine($"{Messages.SUM_EVEN}{Array1D_Operations.SumOfEven()}");
                    MessagesViewer.WriteLine($"{Messages.SUM_ODD}{Array1D_Operations.SumOfOdd()}");
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1D_Operations.ReplaceMinAndMax();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    MessagesViewer.WriteLine($"{Messages.EVEN_MIN}{Array1D_Operations.EvenMin()}");
                    MessagesViewer.WriteLine($"{Messages.ODD_MAX}{Array1D_Operations.OddMax()}");
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1D_Operations.SortFromMinToMAx();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1D_Operations.SortFromMaxToMin();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;

                case ConsoleKey.D6:
                    Console.Clear();
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    break;

                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error(Messages.ERROR_WRONG_BUTTON);
                    break;
            }
            ShowMainMenu();
        }
    }
}
