﻿// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

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

void MassSearchNum(int[] arry, int num)
{
    for (int i = 0; i < arry.Length; i++)
    {
        if (arry[i] == num)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");

}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

Console.WriteLine("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
MassSearchNum(mass, num);
