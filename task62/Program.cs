/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


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

int parties = 4;

int[,] arr = new int[parties, parties];
int index = 0;

for (int x = 0; (x <= parties / 2); x++)
{
    for (int i = x; i < parties - x; i++)
        arr[x, i] = ++index;

    for (int i = x + 1; i < parties - x; i++)
        arr[i, parties - 1 - x] = ++index;

    for (int i = parties - 2 - x; i >= 0 + x; i--)
        arr[parties - 1 - x, i] = ++index;

    for (int i = parties - 2 - x; i > 0 + x; i--)
        arr[i, x] = ++index;
}

PrintArray(arr);