/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int day = new Random().Next(1,8);
Console.WriteLine("День недели: " + day + ".");

// Вариант с оператором IF-ELSE
/*if (day < 6)  Console.WriteLine("Это рабочий день.");
else Console.WriteLine("Это ВЫХОДНОЙ.");*/

// Вариант с оператором SWITCH
switch (day)
{
  case < 6:
    Console.WriteLine("Это рабочий день.");
    break;
  default:
    Console.WriteLine("Это ВЫХОДНОЙ.");
    break;
}