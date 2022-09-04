//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.

Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
Console.WriteLine(num);
Console.WriteLine($"Итоговое число {a1}{a2}");

