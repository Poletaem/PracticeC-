// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

// Только с разбором ДЗ,не самостоятельно!

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
int row_num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:    ");
int column_num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона:    ");
int start_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона:    ");
int stop_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк:    ");
int row_num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:    ");
int column_num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона:    ");
int start_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона:    ");
int stop_2 = int.Parse(Console.ReadLine()!);

int[,] mass_1 = FillMass(row_num_1, column_num_1, start_1, stop_1);
Print(mass_1);
int[,] mass_2 = FillMass(row_num_2, column_num_2, start_2, stop_2);
Print(mass_2);

Console.WriteLine();

int[,]  ProdMass(int[,] firstArr, int[,] secondArr)
{
    int row_1 = firstArr.GetLength(0);
    int column_1 = firstArr.GetLength(1);

    int row_2 = secondArr.GetLength(0);
    int column_2 = secondArr.GetLength(1);
  
    int[,] newArr = new int [row_1, column_1];

    if (column_1 != row_2) return newArr;
    else if (column_1 == row_2)
        newArr = new int[row_1, column_2];

    for (int i = 0; i < row_1; i++)
    {
        for (int j = 0; j < column_2; j++)
        {
            for (int p = 0; p < column_1; p++)
            newArr[i, j] += firstArr[i, p] * secondArr[p, j];
        }
    }
    return newArr;
}

int[,] newArr =  ProdMass(mass_1, mass_2);
Print(newArr);