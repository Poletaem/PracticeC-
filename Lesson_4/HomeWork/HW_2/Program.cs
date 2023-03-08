// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int Sum(int num)
{
    int var = 0;
    
    for(int i = 1; num > 0; i++)
    {
        int A = num % 10;
        num = num /10;
        var = var + A;
    }
    return var;
}

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = Sum(A);
Console.WriteLine(result);