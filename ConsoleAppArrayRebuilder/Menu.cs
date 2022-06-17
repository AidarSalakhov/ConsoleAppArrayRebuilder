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
                    Show2DMenu();
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
                    Array1D_Operations.SortFromMinToMax();
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
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1D_Operations.SortFirstEvenThenOdd();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1D_Operations.CreateEvensArray());
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1D_Operations.CreateOddsArray());
                    break;

                case ConsoleKey.D9:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1D_Operations.ToZeroIfBiggerThen9();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
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

        public static void Show2DMenu()
        {
            MessagesViewer.Show2DMenuText();

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2D_Operations.Replace1And3Lines();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine($"{Messages.SUM_NUMBERS_BIGGER_THEN_9}{Array2D_Operations.SumOfNumbersBiggerThen9()}");
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine($"{Messages.SUM_NUMBERS_MULTIPLE_5}{Array2D_Operations.SumOfNumbersMultiple5()}");
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2D_Operations.Replace1And3Colums();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2D_Operations.ToZeroIfUnderMainDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D6:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2D_Operations.ToZeroIfAboveMainDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2D_Operations.ToZeroIfUnderSecondaryDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2D_Operations.ToZeroIfAboveSecondaryDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
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
