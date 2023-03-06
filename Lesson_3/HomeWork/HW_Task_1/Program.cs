// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int num = int.Parse(Console.ReadLine()!);


void Palindrom(int num)

{
    int a = num / 10000;
    int b = num % 10;
    int a1 = num / 1000 % 10;
    int b1 = num / 10 % 10;

    if(num > 100000 || num < 10000)
    {
        Console.WriteLine("Not 5digits");
    }

    else if (a == b && a1 == b1)
    {
        Console.WriteLine("Palindrom");
    }
    else
    {
        Console.WriteLine("No)");
        }
}

Palindrom(num);