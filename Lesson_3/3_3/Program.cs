// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

int num = int.Parse(Console.ReadLine()!);

void Div(int n)
{
    int i = 1;

    while(n>=i)
    {
        Console.WriteLine(Math.Pow(i,2));
        i++;

    }
}

Div(num);