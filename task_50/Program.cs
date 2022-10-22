/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
             что такого элемента нет.
             Например, задан массив:
             1 4 7 2
             5 9 2 3
             8 4 2 4
             [1,7] -> такого числа в массиве нет
*/
Main();

void Main()
{
    Console.Clear();
    int[,] array = new int[4, 4];
    FillArray(array);
    PrintArray(array);
    Console.Write("Введите идекс строки массива: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите идекс столбца массива: ");
    int columns = int.Parse(Console.ReadLine());
    Console.WriteLine($"По индексу {rows},{columns} - {FindByIndex(array, rows, columns)}");
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 11);
        }
    }
}

string FindByIndex(int[,] arr, int indexRows, int indexColumns)
{
    if (arr.GetLength(0) < indexRows || arr.GetLength(1) < indexColumns) return "такого индекса в массиве нет!";
    else return $"находится число: {arr[indexRows, indexColumns]}";
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}