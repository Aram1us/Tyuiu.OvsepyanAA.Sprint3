﻿using Tyuiu.OvsepyanAA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.OvsepyanAA.Sprint3.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Овсепян А.А| СМАРТб-24 -1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла foreach                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Овсепян Арам Андраникович | СМАРТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Используя цикл foreach подсчитать количество букв “f” в строке: gfft ntf *");
            Console.WriteLine("*f opf                                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var data = "gfft ntf f opf";

            var result = ds.GetCharCount(data, 'f');
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
