// Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

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


int[] MinPosition(int[,] Arr)
{
    int row = Arr.GetLength(0);
    int column = Arr.GetLength(1);
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (Arr[i, j] < Arr[minI, minJ])
            {
                minI = i, minJ = j;  
            }
    return minI, minJ;
}

// Дальше я не знаю
