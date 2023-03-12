//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}    ");
    Console.WriteLine();
}

double[] MassNums(int size, double from, double to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(new Random().NextDouble() * (to - from) + from, 2);
    return arr;
}


double MaxMin(double[] Mass)

{
    double Max; double Min;
    Max = Min = Mass[0];
    

    for (int i = 1; i < Mass.Length; i++)
    {
        if (Mass[i] < Min)
            Min = Mass[i];
    
        else if (Mass[i] > Max)
            Max = Mass[i];
    }
    double Dif = Max - Min;
    return Math.Round(Dif, 2);
}


Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон от");
double start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон до");
double stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();
double[] mass = MassNums(num, start, stop);
Print(mass);

Console.WriteLine();
double result = MaxMin(mass);
Console.WriteLine($" Max - Min = {result}");