// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1, 0, 9);
int[,] array2 = GetArray(rows2, columns2, 0, 9);
int[,] resultArray = GetArray(rows2, columns2, 0, 9);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
ResultMatrix(array1, array2, resultArray);
Console.WriteLine("Результирующая матрица: ");
PrintArray(resultArray);

void ResultMatrix(int[,] arr1, int[,] arr2, int[,] resultArr)     //Здесь где то хорошо бы добавить условие, какие 
{                                                                 //конкретно матрицы можно перемножать, но я не сообразила
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            resultArr[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                //resultArray[i, j] += array1[i, k] * array2[k, j];
                resultArr[i, j] = resultArr[i, j] + arr1[i, k] * arr2[k, j];
            }
        }
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}

