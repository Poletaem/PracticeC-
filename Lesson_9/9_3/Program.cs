// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


int SumDigits(int N)
{
    if(N==0) return 0;
    
    return SumDigits(N / 10) + N%10;
}

int N = int.Parse(Console.ReadLine()!);
Console.Write(SumDigits(N));