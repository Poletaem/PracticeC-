// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.


void SeriesNums(int N)
{

    if (N == 0) return;  //N < 1
    SeriesNums(N - 1);  //--N
    Console.Write($"{N}, ");

}

SeriesNums(int.Parse(Console.ReadLine()!)); 