using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class MessagesViewer
    {
        public static void Info(string message)
        {
            Console.WriteLine($"\t|INFO|\t{message}");
        }
        public static void Error(string message)
        {
            Console.WriteLine($"\t|ERROR|\t{message}");
        }
        public static void Warn(string message)
        {
            Console.WriteLine($"\t|WARNING|\t{message}");
        }
        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowMenuText()
        {
            Console.WriteLine(Messages.INFO_MENU_CHOOSE_ACTION);
            Console.WriteLine(Messages.INFO_MENU_BUTTON_CREATE_1D_ARRAY);
            Console.WriteLine(Messages.INFO_MENU_BUTTON_CREATE_2D_ARRAY);
            Console.WriteLine(Messages.INFO_MENU_BUTTON_CREATE_SUPER_2D_ARRAY);
            Console.WriteLine(Messages.INFO_MENU_BUTTON_CLOSE_PROGRAM);
        }

        public static void Show1DMenuText()
        {
            Console.WriteLine(Messages.INFO_1D_MENU_SIMPLE_SEARCH);
            Console.WriteLine(Messages.INFO_1D_MENU_EVEN_ODD_SUM);
            Console.WriteLine(Messages.INFO_1D_MENU_MIN_MAX);
            Console.WriteLine(Messages.INFO_1D_MENU_MIN_EVEN_MAX_ODD);
            Console.WriteLine(Messages.INFO_1D_MENU_SIMPLED_SORT);
            Console.WriteLine(Messages.INFO_1D_MENU_SORT_BY_GROWTH);
            Console.WriteLine(Messages.INFO_1D_MENU_SORT_BY_DESC);
            Console.WriteLine(Messages.INFO_1D_MENU_SORT_ODD_EVEN);
            Console.WriteLine(Messages.INFO_1D_MENU_CHOSING_ELEMENT);
            Console.WriteLine(Messages.INFO_1D_MENU_ODD_OR_EVEN);
            Console.WriteLine(Messages.INFO_1D_MENU_DOUBLE_TO_ZERO);
        }
    }
}
