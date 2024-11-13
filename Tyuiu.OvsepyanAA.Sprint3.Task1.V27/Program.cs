﻿using Tyuiu.OvsepyanAA.Sprint3.Task1.V27.Lib;

namespace Tyuiu.OvsepyanAA.Sprint3.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Овсепян А.А | СМАРТб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 3                                                                  *");
            Console.WriteLine("*Тема: Оператор цикла while                                                *");
            Console.WriteLine("*Задание #1                                                                *");
            Console.WriteLine("*Вариант #27                                                               *");
            Console.WriteLine("*Выполнил: Овсепян Арам Андраникович| СМАРТб-24-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение  *");
            Console.WriteLine("* ряда по формуле, при n=0,75                                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;
            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(value: "Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadLine();
        }
    }
}
