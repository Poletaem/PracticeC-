//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4


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

int[,] MassNums(int row, int column, int from, int to)
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

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);


Console.WriteLine("Введите строку элемента:    ");
int Row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите столбец элемента:    ");
int Col = int.Parse(Console.ReadLine()!);
Console.WriteLine();


string SearchElement(int[,]Arr, int I, int J)

{int row = Arr.GetLength(0);
int column = Arr.GetLength(1);



        if( I >  row || J > column)
           return "Элемента с такой позицией нет";

 return $"{Arr[I-1,J-1]}";
}

string result = SearchElement(mass, Row, Col);
Console.WriteLine(result);