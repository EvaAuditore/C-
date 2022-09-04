//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 % number2 ==0)
{
    Console.WriteLine($"{number1},{number2} -> кратно");
}
else
{
    int number3 = number1 % number2;
    Console.WriteLine($"{number1},{number2} -> не кратно, остаток {number3}");
}