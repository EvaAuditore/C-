// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
double[] array = GetArray(5, 0, 98);

double Method(double[] array)
{
    double MaxNumber = array[0];
    double MinNumber = array[0];
    double difference = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (MaxNumber < array[i])
        {
            MaxNumber = array[i];
        }
        if (MinNumber > array[i])
        {
            MinNumber = array[i];
        }
    }
    difference = MaxNumber - MinNumber;
    return difference;
}
double difference = Method(array);
Console.WriteLine($"Разница между между максимальным и минимальным элементами: {difference}");