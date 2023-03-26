﻿// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Половина не работает(

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

int SumRow(int[,] Arr)
{
    int row = Arr.GetLength(0);
    int column = Arr.GetLength(1);
    int sum = 0;
    int[] Num = new int[Arr.GetLength(0)];
    for (int i = 0; i < row; i++)
    {
        sum = 0;
        for (int j = 0; j < column; j++)
        {
            Num[i] = sum + Arr[i, j];
        } 
    }
    return Num;
}    
int[] Num = SumRow(mass);

int MinRow(int[] Arr)
{
    int size = arr.Length;
    int min = 0;
    for (int i = 0; i < size; i++)
    {
        if(Arr[i] < Arr[min])
            min = i;
    }
    return min;
}
int result = MinRow(mass);
Console.WriteLine(result);

