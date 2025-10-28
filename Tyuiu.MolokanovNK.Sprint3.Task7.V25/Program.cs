using Tyuiu.MolokanovNK.Sprint3.Task7.V25.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                            *");
Console.WriteLine("* Задание #7                                                                                  *");
Console.WriteLine("* Вариант #25                                                                                 *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                      *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
Console.WriteLine("***********************************************************************************************");


Console.WriteLine("Таблица значений функции F(x) = cos(x) + (4x)/2 - sin(x) * 3x");
Console.WriteLine("Диапазон: [-5; 5] с шагом 1");
Console.WriteLine("=============================================");
Console.WriteLine("   x    |    F(x)    ");
Console.WriteLine("--------|-------------");

double[] results = ds.GetMassFunction(-5, 5);

for (int i = 0; i < results.Length; i++)
{
    int x = -5 + i;
    Console.WriteLine($"{x,7:F1} | {results[i],11:F6}");
}