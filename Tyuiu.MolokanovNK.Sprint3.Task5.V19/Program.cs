using Tyuiu.MolokanovNK.Sprint3.Task5.V19.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                              *");
Console.WriteLine("* Задание #5                                                                                    *");
Console.WriteLine("* Вариант #19                                                                                   *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                        *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


int x = 2;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 6;

Console.WriteLine("Переменная Х = " + x);
Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("Сумма суммы ряда = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));
Console.ReadKey();
