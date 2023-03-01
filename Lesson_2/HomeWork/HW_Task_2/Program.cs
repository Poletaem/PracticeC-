// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.


int DelSec(int num)

{
    Console.WriteLine(num);
    return num / 100 * 10 + (num % 100 % 10);
}

int result = DelSec(new Random().Next(100, 1000));
Console.WriteLine(result);