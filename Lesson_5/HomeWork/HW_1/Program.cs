//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}


int Even(int[] Mass)
{
    int count = 0;
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i]%2 == 0)
            count = count + 1;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num);
Print(mass);

int result = Even(mass);
Console.WriteLine($"Количество четных элементов = {result}" );