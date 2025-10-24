using Tyuiu.MolokanovNK.Sprint3.Task3.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                            *");
Console.WriteLine("* Задание #3                                                                                  *");
Console.WriteLine("* Вариант #28                                                                                 *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                      *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
Console.WriteLine("* Используя цикл foreach заменить цифры на букву r в строке                                   *");
Console.WriteLine("*                                                                                             *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
Console.WriteLine("***********************************************************************************************");

string value = "f35hyt t4j 3gkg45";
char item = 'r';

Console.WriteLine("Исходная строка = " + value);
Console.WriteLine("Символ заменяемый числа = " + item);

Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");


Console.WriteLine("Результат = " + ds.ReplaceNumOnChar(value, item));

Console.ReadKey();  