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
        public static void ShowMenu()
        {
            MessagesViewer.Info(Constants.PROGRAM_NAME);
            MessagesViewer.Info(Messages.INFO_MENU_CHOOSE_ACTION);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_CREATE_1D_ARRAY);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_CREATE_2D_ARRAY);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_CREATE_SUPER_2D_ARRAY);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_CLOSE_PROGRAM);

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.O:
                    Console.Clear();
                    ArrayCreator.Print1DArray(ArrayCreator.CreateAndFill1DArray(5));
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
                    ShowMenu();
                    break;
            }
            ShowMenu();
        }
    }
}
