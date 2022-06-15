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
        public static void Default(string message)
        {
            Console.Write(message);
        }
    }
}
