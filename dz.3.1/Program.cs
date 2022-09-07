// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
string number2 = number;
if (number.Length == 5)
{
    number2 = number;
}
else
{
    Console.WriteLine($"Введите правильное число");
    return;
}

if (number[0] == number[4] || number[1] == number[3])
{
    Console.WriteLine($"{number} -> палиндром");
}
else
{
    Console.WriteLine($"{number} -> НЕ палиндром");
}

