// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

int n= int.Parse(Console.ReadLine()!);

void Div(int n)
{
    if(n % 7 == 0 & n % 23 == 0)
        Console.WriteLine("кратно");
    else
        Console.WriteLine("не кратно");
}
Div(n);
    

    


