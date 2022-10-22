/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Main();

// Не смог решить, как более оптимально по ресурсо-затратам решить данную задачу,
// написал два метода, через String и через создание нового масива double.
// Закомментированные строки 22,23,24 - решение через double. 


void Main()
{
    Console.Clear();
    int[,] array = new int[4, 4];
    FillArray(array);
    PrintArray(array);
    // Console.Write("Среднее арифметическое каждого столбца: ");
    // double[] averColum = AverageColumns(array);
    // PrintArrayDouble(averColum);
    Console.Write(AverageColumnsString(array));
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
}

double [] AverageColumns (int[,] arr)            // Метод нахождения через создание нового массива double 
{
    double[] average = new double[arr.GetLength(1)];
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        double sum =0.0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[j,i]; 
        }
        average[i] = sum/arr.GetLength(1);
    }
    return average;
}

string AverageColumnsString (int[,] arr)            // Метод нахождения через String
{
    string result = "Среднее арифметическое каждого столбца: ";
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        
        double sum =0.0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[j,i]; 
        }
        result += $"{sum/arr.GetLength(1)}; ";
    }
    return result;
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

void PrintArrayDouble(double[] arr)                          
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + "; ");
        }
        else
        {
            Console.Write(arr[i] + ".");
        }
    }
    Console.WriteLine();
}