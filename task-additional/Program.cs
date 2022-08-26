//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да


// Число кратное одновременно 7 и 23, кратно их произведению 7*23=161
Console.WriteLine("Задайте случайное целое число: ");
try //блок try-catch на случай некорректного ввода данных
{

int number = Convert.ToInt32(Console.ReadLine());
number = number % 161;
if (number == 0) Console.WriteLine("кратно");
else Console.WriteLine("не кратно");

}
catch 
{Console.WriteLine("Не корректный ввод данных.");}