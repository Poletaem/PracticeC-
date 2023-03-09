// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}


int RetNum(int[] Mass, int from, int to)

{
    int count = 0;
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] >= from & Mass[i] <= to)
            count = count + 1;

    }
    return count;   //если ретёрн в цикле, то бндет только одна интерация
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);


Console.WriteLine("Введите начало диапазона: ");
int first = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите конец диапазона: ");
int sec = int.Parse(Console.ReadLine()!);

int result = RetNum(mass, first, sec);

Console.WriteLine(result);