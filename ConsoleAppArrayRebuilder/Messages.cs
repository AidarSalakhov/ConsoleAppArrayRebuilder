using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayRebuilder
{
    internal class Messages
    {   
        //Название программы
        public const string PROGRAM_NAME = "Console App: Array Rebuilder v. 1.0";
        //-----------

        //Главное меню
        public const string INFO_MENU_CHOOSE_ACTION = "---------------Выберите действие---------------";
        public const string INFO_MENU_BUTTON_CREATE_1D_ARRAY = "[O] - Создать и редактировать одномерный массив [5]";
        public const string INFO_MENU_BUTTON_CREATE_2D_ARRAY = "[T] - Создать и редактировать двумерный массив [3,3]";
        public const string INFO_MENU_BUTTON_CREATE_SUPER_2D_ARRAY = "[N] - Создать и редактировать двумерный массив [X,Y]";
        public const string INFO_MENU_BUTTON_CLOSE_PROGRAM = "[Esc] - Выйти из программы";
        //-----------


        //Кнопка [O] Меню действий для одномерного массива
        public const string INFO_1D_MENU_EVEN_ODD_SUM = "[1] - Найти сумму четных и сумму нечетных элементов массива.";
        public const string INFO_1D_MENU_MIN_MAX = "[2] - Найти в массиве минимальный и максимальный элементы, поменять их местами, вывести результат.";
        public const string INFO_1D_MENU_MIN_EVEN_MAX_ODD = "[3] - Найти и вывести на экран в массиве четный минимальный и нечетный максимальный элементы.";
        public const string INFO_1D_MENU_SORT_BY_GROWTH = "[4] - Программа отсортировывает массив по возрастанию.";
        public const string INFO_1D_MENU_SORT_BY_DESC = "[5] - Программа отсортировывает массив по убыванию.";
        public const string INFO_1D_MENU_SORT_ODD_EVEN = "[6] - Отсортировать, так чтобы первыми в массиве шли четные числа, а после них нечетные.";
        public const string INFO_1D_MENU_EVEN = "[7] - Программа, которая выводит только четные элементы массива.";
        public const string INFO_1D_MENU_ODD = "[8] - Программа, которая выводит только нечетные элементы массива.";
        public const string INFO_1D_MENU_DOUBLE_TO_ZERO = "[9] - Программа, которая обнуляет двузначные элементы массива и выводит результат.";
        public const string INFO_MENU_REFRSH_ARRAY = "[F5] - Обновить элементы массива";
        public const string INFO_MENU_BACK_TOMAIN_MENU = "[Backspace] - Вернуться в главное меню";

        //Кнопка [1] Текст под кнопкой
        public const string SUM_EVEN = "Сумма чётных чисел массива: ";
        public const string SUM_ODD = "Сумма нечётных чисел массива: ";

        //Кнопка [3] Текст под кнопкой
        public const string EVEN_MIN = "Чётный минимальный: ";
        public const string ODD_MAX = "Нечётный максимальный: ";
        //-----------


        //Кнопка [T] Меню действий для двумерного массива 3х3
        public const string INFO_2D_MENU_CHANGE_1_AND_3_LINES = "[1] - Поменять местами элементы 1-й и 3-й строк, вывести результат.";
        public const string INFO_2D_MENU_SUM_OF_BIGGER_THEN_9 = "[2] - Найти сумму всех двузначных элементов.";
        public const string INFO_2D_MENU_SUM_OF_ELEMENTS_MULTIPLE_5 = "[3] - Найти сумму всех элементов, кратных 5.";
        public const string INFO_2D_MENU_CHANGE_1_AND_3_COLUMN = "[4] - Поменять местами элементы 1-го и 3-го столбцов, вывести результат.";
        public const string INFO_2D_MENU_TO_ZERO_IF_UNDER_MAIN_DIAGONAL = "[5] - Обнулить элементы ниже главной диагонали.";
        public const string INFO_2D_MENU_TO_ZERO_ABOVE_MAIN_DIAGONAL = "[6] - Обнулить элементы выше главной диагонали.";
        public const string INFO_2D_MENU_TO_ZERO_IF_UNDER_SECONDARY_DIAGONAL = "[7] - Обнулить элементы элементы ниже побочной диагонали.";
        public const string INFO_2D_MENU_TO_ZERO_IF_ABOVE_SECONDARY_DIAGONAL = "[8] - Обнулить элементы выше побочной диагонали.";

        //Кнопка [2] Текст под кнопкой
        public const string SUM_NUMBERS_BIGGER_THEN_9 = "Сумма всех двузначных элементов: ";

        //Кнопка [3] Текст под кнопкой
        public const string SUM_NUMBERS_MULTIPLE_5 = "Сумма всех элементов, кратных 5: ";
        //-----------


        //Кнопка [N] Меню действий для двумерного массива 3х3
        public const string INFO_2DS_MENU_TO_ZERO_AVOBE_MAIN_DIAGONAL_IF_LOWER_THAN_X = "[1] - Программа обнуляет элементы выше главной диагонали массива, которые меньше числа X";
        public const string INFO_2DS_MENU_TO_SHOW_ELEMENTS_AVOBE_SECONDARY_DIAGONAL_IF_LOWER_THAN_X = "[2] - Программа находит элементы выше побочной диагонали массива, которые меньше числа X и выводит эти числа";

        //Кнопка [1] Текст под кнопкой
        public const string INFO_2DS_MENU_ENTER_X = "Введите число X: ";

        //Кнопка [2] Текст под кнопкой
        public const string INFO_2DS_ELEMENTS_ABOVE_SECONDARY_DIAGONAL_LOWER_THAN_X = "Элементы выше побочной диагонали массива, которые меньше числа X: ";

        //Задание размерности двумерного супер-массива
        public const string INFO_ENTER_ARRAY_HEIGH = "Введите количество строк массива:";
        public const string INFO_ENTER_ARRAY_LENGTH = "Введите количество столбцов массива:";
        //-----------


        //Ошибки
        public const string ERROR_WRONG_BUTTON = "Вы нажали неверную кнопку";
        public const string ERROR_WRONG_SYMBOL = "Вы ввели неверный символ, введите целое число";
        //-----------
    }
}
