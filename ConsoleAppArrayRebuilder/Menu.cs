using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            MessagesViewer.Info(Constants.PROGRAM_NAME);
            MessagesViewer.Info(Messages.INFO_MENU_CHOOSE_ACTION);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_N1_ARRAY);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_N2_ARRAY);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_NX_ARRAY);
            MessagesViewer.Info(Messages.INFO_MENU_BUTTON_CLOSE_PROGRAM);

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.O:

                    Console.Clear();
                    break;

                case ConsoleKey.T:
                    Console.Clear();
                    break;

                case ConsoleKey.N:
                    Console.Clear();
                    break;

                case ConsoleKey.Escape:
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error(Messages.ERROR_WRONG_BUTTON);
                    ShowMenu();
                    break;
            }
        }
    }
}
