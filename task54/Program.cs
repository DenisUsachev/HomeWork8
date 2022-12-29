/*Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] arr =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write (arr [i, j] + " ");
        }
        Console.WriteLine ();
    }
}


int [,] SortArr (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1); a++)
            {
                if (array[i, a] < array[i, j])
                {
                    int temp = array [i, j];
                    array[i, j] = array[i, a];
                    array[i, a] = temp;
                }
            }
        }
    }
    return array;
}


PrintArray(arr);

int[,] sortArray = SortArr(arr);

Console.WriteLine($"Отсортированный массив:");
PrintArray(sortArray);