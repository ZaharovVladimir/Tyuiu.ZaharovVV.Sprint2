﻿using Tyuiu.ZaharovVV.Sprint2.Task2.V13.Lib;
namespace Tyuiu.ZaharovVV.Sprint2.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 2 | Выполнил: Захаров В.В. | ИСТНб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #13                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и    *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int x, y;
            Console.WriteLine("Введите первую координату : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Введенное число находится внутри закрашенной области");
            }
            else
            {
                Console.WriteLine("Введенное число находится вне закрашенной области");
            }
            Console.ReadKey();
        }
    }
}