// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fib(int a)
{
    int ferstNum = 0;
    int secondNum = 1;
    for (int i = 0; i < a; i++)
    {
        Console.Write(ferstNum + " ");
        (ferstNum, secondNum) = (secondNum, ferstNum + secondNum);
    }
}
int A = int.Parse(Console.ReadLine()!);
Fib(A);