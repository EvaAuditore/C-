﻿// 14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if((number % 7 == 0) && (number % 23 == 0))
{
  Console.WriteLine($"{number} -> да");
}
else
{
  Console.WriteLine($"{number} -> нет");
}