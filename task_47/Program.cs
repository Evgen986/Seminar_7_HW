/*  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
               m = 3, n = 4.
               0,5 7 -2 -0,2
               1 -3,3 8 -9,9
               8 7,8 -7,1 9
*/
Main();

void Main()
{
    Console.Clear();
    double[,] array = GetArray(new Random().Next(4,8), new Random().Next(4,8));
    PrintArray(array);
}

double[,] GetArray(int sizeRows, int sizeColumns)
{
    double[,] arr = new double[sizeRows, sizeColumns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i%2 != 0 && j%2 == 0)    // Добавил ветвление, что-бы ввести в массив числа отрицательного диапозона
            {
                arr[i, j] = Math.Round(new Random().NextDouble() * -10, 2);
            }
            else arr[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
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