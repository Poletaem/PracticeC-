// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.



void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
     Console.WriteLine();
}

int[,] FillMass(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}


Console.WriteLine("Введите количество строк:    ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:    ");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона:    ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона:    ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = FillMass(row_num, column_num, start, stop);
Console.WriteLine();
Print(mass);


void ReplaceIndex(int[,] array)
{
    int ArrayRow = array.GetLength(0);
    int ArrayColumn = array.GetLength(1);
    
    for (int j = 0; j < ArrayColumn; j++)
    {
        (array[0,j] , array[ArrayRow - 1 ,j]) = (array[ArrayRow - 1, j], array[0,j]);
    }
}

ReplaceIndex(mass);
Print(mass);