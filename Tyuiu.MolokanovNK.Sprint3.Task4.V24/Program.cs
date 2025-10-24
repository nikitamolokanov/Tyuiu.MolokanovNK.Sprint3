using Tyuiu.MolokanovNK.Sprint3.Task4.V24.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                     *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                              *");
Console.WriteLine("* Задание #4                                                                                    *");
Console.WriteLine("* Вариант #24                                                                                   *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                        *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=(sin(x)/x)+2    *");
Console.WriteLine("* При х = 0 прервать цикл. Полученные значения перемножать.                                     *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");


int startValue = -5;
int stopValue = 5;


Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");


Console.WriteLine("Сумма ряда = " + ds.Calculate( startValue, stopValue));
Console.ReadKey();

