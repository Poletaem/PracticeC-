// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// https://4apple.org/summa-diagonalnyh-jelementov-matricy/

//Тернарный оператор
https://codechick.io/tutorials/csharp/csharp-ternary-operator


int SumMainDiag(int[,] arr)
{
    int sum = 0;

    int minSize = arr.GetLength(0);
    if (arr.GetLength(0) > arr.GetLength(1))
        minSize = arr.GetLength(1);

    // int minSize = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);

    for (int i = 0; i < minSize; i++)
        sum += arr[i, i];
    return sum;
}