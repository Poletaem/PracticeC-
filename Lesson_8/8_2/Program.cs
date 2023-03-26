// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.


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




bool Check(int row, int column)
{    
    bool result = row != column;
    return result;
}

string RowToColumn(int[,] array)
{
    if (Check(array.GetLength(0), array.GetLength(1))) return "Нет!";

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    Print(array);
    return "Да!";
}

string result = RowToColumn(mass);
Console.WriteLine(result);
