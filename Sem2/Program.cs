﻿// 3 Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите число от 1 до 7");
string numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);

if (numberInt == 1)
{
Console.WriteLine("Понедельник");
}

if (numberInt == 2)
{
Console.WriteLine("Вторник");
}

if (numberInt == 3)
{
Console.WriteLine("Среда");
}

if (numberInt == 4)
{
Console.WriteLine("Четверг");
}

if (numberInt == 5)
{
Console.WriteLine("Пятница");
}
if (numberInt == 6)
{
Console.WriteLine("Суббота");
}
if (numberInt == 7)
{
Console.WriteLine("Воскресенье");
}
 if (numberInt > 8 || numberInt == 8 || numberInt < 1)
 {
Console.WriteLine("Такого дня недели не существует!");
 }
