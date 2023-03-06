// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int num = int.Parse(Console.ReadLine()!);

void Div(int n)

{
    Console.Write("");

    int i = 1;

    while (n >= i)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }

    int j = -1;

    while (j >= n)
    {
        Console.WriteLine(Math.Pow(j, 3));
        j--;
    }

}

Div(num);