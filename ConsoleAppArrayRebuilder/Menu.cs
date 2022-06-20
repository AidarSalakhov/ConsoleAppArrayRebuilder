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
                    Show2DSMenu();
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
                    MessagesViewer.WriteLine($"{Messages.SUM_EVEN}{Array1DMethods.SumOfEven(ArrayCreator.array1D)}");
                    MessagesViewer.WriteLine($"{Messages.SUM_ODD}{Array1DMethods.SumOfOdd(ArrayCreator.array1D)}");
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.ReplaceMinAndMax(ArrayCreator.array1D));
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    MessagesViewer.WriteLine($"{Messages.EVEN_MIN}{Array1DMethods.EvenMin(ArrayCreator.array1D)}");
                    MessagesViewer.WriteLine($"{Messages.ODD_MAX}{Array1DMethods.OddMax(ArrayCreator.array1D)}");
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.SortFromMinToMax(ArrayCreator.array1D));
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.SortFromMaxToMin(ArrayCreator.array1D));
                    break;

                case ConsoleKey.D6:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.SortFirstEvenThenOdd(ArrayCreator.array1D));
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.CreateEvensArray(ArrayCreator.array1D));
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.CreateOddsArray(ArrayCreator.array1D));
                    break;

                case ConsoleKey.D9:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.ToZeroIfBiggerThen9(ArrayCreator.array1D));
                    break;

                case ConsoleKey.F5:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.CreateAndFill1DArray(5));
                    Show1DMenu();
                    break;

                case ConsoleKey.Backspace:
                    Console.Clear();
                    ShowMainMenu();
                    break;

                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error(Messages.ERROR_WRONG_BUTTON);
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;
            }
            Show1DMenu();
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
                    ArrayCreator.Print2DArray(Array2DMethods.Replace1And3Lines(ArrayCreator.array2D));
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine($"{Messages.SUM_NUMBERS_BIGGER_THEN_9}{Array2DMethods.SumOfNumbersBiggerThen9(ArrayCreator.array2D)}");
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine($"{Messages.SUM_NUMBERS_MULTIPLE_5}{Array2DMethods.SumOfNumbersMultiple5(ArrayCreator.array2D)}");
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    ArrayCreator.Print2DArray(Array2DMethods.Replace1And3Colums(ArrayCreator.array2D));
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    ArrayCreator.Print2DArray(Array2DMethods.ToZeroIfUnderMainDiagonal(ArrayCreator.array2D));
                    break;

                case ConsoleKey.D6:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    ArrayCreator.Print2DArray(Array2DMethods.ToZeroIfAboveMainDiagonal(ArrayCreator.array2D));
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    ArrayCreator.Print2DArray(Array2DMethods.ToZeroIfUnderSecondaryDiagonal(ArrayCreator.array2D));
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    ArrayCreator.Print2DArray(Array2DMethods.ToZeroIfAboveSecondaryDiagonal(ArrayCreator.array2D));
                    break;

                case ConsoleKey.F5:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.CreateAndFill2DArray(3,3));
                    Show2DMenu();
                    break;

                case ConsoleKey.Backspace:
                    Console.Clear();
                    ShowMainMenu();
                    break;

                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error(Messages.ERROR_WRONG_BUTTON);
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;
            }
            Show2DMenu();
        }

        public static void Show2DSMenu()
        {
            MessagesViewer.Show2DSMenuText();

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine(Messages.INFO_2DS_MENU_ENTER_X);
                    try
                    {
                        ArrayCreator.Print2DArray(Array2DSMethods.ToZeroAboveMainDiagonalIfLowerThanX(Convert.ToInt32(Console.ReadLine()), ArrayCreator.array2D));
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        MessagesViewer.Error(Messages.ERROR_WRONG_SYMBOL);
                        ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    }
                    
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine(Messages.INFO_2DS_MENU_ENTER_X);
                    try
                    {
                        ArrayCreator.Print1DArray(Array2DSMethods.AboveSecondaryDiagonalLowerThanXToArray(Convert.ToInt32(Console.ReadLine()), ArrayCreator.array2D));
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        MessagesViewer.Error(Messages.ERROR_WRONG_SYMBOL);
                        ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    }
                    break;

                case ConsoleKey.F5:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.Create2DSuperArray());
                    Show2DSMenu();
                    break;

                case ConsoleKey.Backspace:
                    Console.Clear();
                    ShowMainMenu();
                    break;

                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error(Messages.ERROR_WRONG_BUTTON);
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;
            }
            Show2DSMenu();
        }

    }
}
