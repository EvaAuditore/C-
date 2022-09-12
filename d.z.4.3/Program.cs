// Задача 29: Напишите программу, которая задаёт массив из
//  8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[99];
void Method1(int[] arr)
{
    int lenght = arr.Length;
    int index = 0;
    Console.Write("[");
    while (index < lenght)
    {
        arr[index] = new Random().Next(0, 9);
        Console.Write($"{arr[index]}, ");
        index++;
    }
    Console.Write("]");
}
Method1(array);   
