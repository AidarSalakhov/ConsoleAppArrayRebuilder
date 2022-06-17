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
                    MessagesViewer.WriteLine($"{Messages.SUM_EVEN}{Array1DMethods.SumOfEven()}");
                    MessagesViewer.WriteLine($"{Messages.SUM_ODD}{Array1DMethods.SumOfOdd()}");
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1DMethods.ReplaceMinAndMax();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    MessagesViewer.WriteLine($"{Messages.EVEN_MIN}{Array1DMethods.EvenMin()}");
                    MessagesViewer.WriteLine($"{Messages.ODD_MAX}{Array1DMethods.OddMax()}");
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1DMethods.SortFromMinToMax();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1DMethods.SortFromMaxToMin();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;

                case ConsoleKey.D6:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1DMethods.SortFirstEvenThenOdd();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.CreateEvensArray());
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    ArrayCreator.Print1DArray(Array1DMethods.CreateOddsArray());
                    break;

                case ConsoleKey.D9:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.array1D);
                    Array1DMethods.ToZeroIfBiggerThen9();
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
                    Array2DMethods.Replace1And3Lines();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine($"{Messages.SUM_NUMBERS_BIGGER_THEN_9}{Array2DMethods.SumOfNumbersBiggerThen9()}");
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine($"{Messages.SUM_NUMBERS_MULTIPLE_5}{Array2DMethods.SumOfNumbersMultiple5()}");
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2DMethods.Replace1And3Colums();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2DMethods.ToZeroIfUnderMainDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D6:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2DMethods.ToZeroIfAboveMainDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D7:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2DMethods.ToZeroIfUnderSecondaryDiagonal();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D8:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    Array2DMethods.ToZeroIfAboveSecondaryDiagonal();
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
                    Array2DSMethods.ToZeroAboveMainDiagonalIfLowerThanX(Convert.ToInt32(Console.ReadLine()));
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCreator.Print2DArray(ArrayCreator.array2D);
                    MessagesViewer.WriteLine(Messages.INFO_2DS_MENU_ENTER_X);
                    Array2DSMethods.AboveSecondaryDiagonalLowerThanXToArray(Convert.ToInt32(Console.ReadLine()));
                    MessagesViewer.WriteLine(Messages.INFO_2DS_ELEMENTS_ABOVE_SECONDARY_DIAGONAL_LOWER_THAN_X);
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

    }
}
