//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int num = int.Parse(Console.ReadLine()!);

void Week(int num)

{
    if (num > 0 & num <6)
        Console.WriteLine("Будний день");
    else if(num == 6 || num == 7)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Error");

    
}   

Week(num);