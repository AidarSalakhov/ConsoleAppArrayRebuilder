using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Messages
    {
        //Главное меню
        public const string INFO_MENU_CHOOSE_ACTION = "---------------Выберите действие---------------";
        public const string INFO_MENU_BUTTON_CREATE_1D_ARRAY = "[O] - Создать и редактировать одномерный массив [5]";
        public const string INFO_MENU_BUTTON_CREATE_2D_ARRAY = "[T] - Создать и редактировать двумерный массив [3,3]";
        public const string INFO_MENU_BUTTON_CREATE_SUPER_2D_ARRAY = "[N] - Создать и редактировать двумерный массив [X,Y]";
        public const string INFO_MENU_BUTTON_CLOSE_PROGRAM = "[Esc] - Выйти из программы";

        //Кнопка [O] Меню действий для одномерного массива
        public const string INFO_1D_MENU_SIMPLE_SEARCH = "----Простой поиск----";
        public const string INFO_1D_MENU_EVEN_ODD_SUM = "[1] - Найти сумму четных и сумму нечетных элементов массива.";
        public const string INFO_1D_MENU_MIN_MAX = "[2] - Найти в массиве минимальный и максимальный элементы, поменять их местами, вывести результат.";
        public const string INFO_1D_MENU_MIN_EVEN_MAX_ODD = "[3] - Найти и вывести на экран в массиве четный минимальный и нечетный максимальный элементы.";
        public const string INFO_1D_MENU_SIMPLED_SORT = "----Простая сортировка----";
        public const string INFO_1D_MENU_SORT_BY_GROWTH = "[4] - Программа отсортировывает массив по возрастанию.";
        public const string INFO_1D_MENU_SORT_BY_DESC = "[5] - Программа отсортировывает массив по убыванию.";
        public const string INFO_1D_MENU_SORT_ODD_EVEN = "[6] - Отсортировать, так чтобы первыми в массиве шли четные числа, а после них нечетные.";
        public const string INFO_1D_MENU_CHOSING_ELEMENT = "----Выборка элементов----";
        public const string INFO_1D_MENU_EVEN = "[7] - Программа, которая по выбору пользователя выводит только четные элементы массива.";
        public const string INFO_1D_MENU_ODD = "[8] - Программа, которая по выбору пользователя выводит только нечетные элементы массива.";
        public const string INFO_1D_MENU_DOUBLE_TO_ZERO = "[9] - Программа, которая обнуляет двузначные элементы массива и выводит результат.";

        //Кнопка [1] Текст под кнопкой
        public const string SUM_EVEN = "Сумма чётных чисел массива:";
        public const string SUM_ODD = "Сумма нечётных чисел массива:";

        //Кнопка [3] Текст под кнопкой
        public const string EVEN_MIN = "Чётный минимальный:";
        public const string ODD_MAX = "Нечётный максимальный:";

        //Задание размерности двумерного супер-массива
        public const string INFO_ENTER_ARRAY_HEIGH = "Введите количество строк массива:";
        public const string INFO_ENTER_ARRAY_LENGTH = "Введите количество столбцов массива:";

        //Ошибки
        public const string ERROR_WRONG_BUTTON = "Вы нажали неверную кнопку";

    }
}
