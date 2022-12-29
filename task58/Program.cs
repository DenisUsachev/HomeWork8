/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] array0 =
{
    { 2, 4 },
    { 3, 2 }
};

int[,] array1 =
{
    { 3, 4 },
    { 3, 3 }
};

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SummArrays (int[,] n, int[,] m)
{
    int x = n.GetLength(0);
    int y = m.GetLength(1);

    int[,] summ = new int[x, y];

    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < n.GetLength(1); k++)
                summ[i, j] += n[i, k] * m[k, j];

    return summ;
}


Console.WriteLine("Первая матрица:");
PrintArray(array0);
Console.WriteLine("Вторая матрица:");
PrintArray(array1);
Console.WriteLine("Сумма матриц:");
PrintArray(SummArrays(array0, array1));
