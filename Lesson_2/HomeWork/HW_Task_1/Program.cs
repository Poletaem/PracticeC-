//  Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int num = int.Parse(Console.ReadLine()!);

int SecNum(int num)
{
    if(num > -1000 & num < -99 || num > 99 & num <1000)
        return num % 100 /10;
    else 
        return num;
}

int result = SecNum(num);
Console.WriteLine(result);