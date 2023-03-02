// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6




int num = int.Parse(Console.ReadLine()!);

 void ThirdNum(int num)
{
    while(num >999 || num < -1000)
        num = num / 10;
    if(num > -1000 & num <- 99 || num > 99 & num < 1000)
        Console.WriteLine(num % 100 % 10);
    else if(num > -100 & num < 100)
        Console.WriteLine($"{num} Нет третьей цифры");
}

ThirdNum(num);


