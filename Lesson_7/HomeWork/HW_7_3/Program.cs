//. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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


void Averege(int[,]Arr)
{
    int row = Arr.GetLength(0);
    int column = Arr.GetLength(1);
    double avr = 0;

    for (int j = 0; j < column; j++)
    {   avr = 0;

        for (int i = 0; i < row; i++)
        {
            avr = avr + Arr[i, j];

        }

    avr = Math.Round(avr / row_num, 2);
    Console.Write($" {avr};  ");
    }
   
}


Averege(mass);

