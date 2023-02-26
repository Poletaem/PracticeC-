Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
 Console.WriteLine();

int count = 2;
while(count < a)
{
    Console.WriteLine($"{count} ");
    count = count + 2;
}

