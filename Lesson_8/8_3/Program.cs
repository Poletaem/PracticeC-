// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9



int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine())!;
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(maxValue + 1);
}

string Print2DArray(int[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res += "\t";
            else
                res += "\n";
        }
    return res;
}

int[] Frequency(int[,] array, int maxValue)
{
    int[] dict = new int[maxValue + 1];

    foreach (int element in array)
    {
        dict[element] += 1;
    }
    return dict;
}

string PrintFrequency(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += $"Число {i} встречается {array[i]} раз\n";
    return res;
}


int numRows = InputNum("Input a number of rows: ");
int numCols = InputNum("Input a numbers of columns: ");
int[,] myArray = Create2DArray(numRows, numCols);
int max = InputNum("Input a max value: ");
Fill2DArray(myArray, max);
string result = Print2DArray(myArray);
Console.WriteLine(result);

int[] dictionary = Frequency(myArray, max);
string res = PrintFrequency(dictionary);

System.Console.WriteLine(res);