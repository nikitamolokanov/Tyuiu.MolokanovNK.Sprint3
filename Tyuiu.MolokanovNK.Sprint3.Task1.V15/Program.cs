using Tyuiu.MolokanovNK.Sprint3.Task1.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                              *");
Console.WriteLine("* Задание #1                                                                                    *");
Console.WriteLine("* Вариант #15                                                                                   *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                        *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле       *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

int value = 2;
int startValue = 1;
int stopValue = 5;

Console.WriteLine("Переменная Х = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
