// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int Method(int[] num2)
{
    int count = 0;
    for (int i = 0; i < num2.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
}

PrintArray(num);
Console.Write("- >");
Console.WriteLine($" {Method(num)} ") ;
// int res = Method(num);
// Console.Write($" {res}");

