using Tyuiu.MolokanovNK.Sprint3.Task6.V26.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                            *");
Console.WriteLine("* Задание #6                                                                                  *");
Console.WriteLine("* Вариант #26                                                                                 *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                      *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
Console.WriteLine("***********************************************************************************************");

int startValue = 15;
int stopValue = 22;

Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);

Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");


Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadKey();