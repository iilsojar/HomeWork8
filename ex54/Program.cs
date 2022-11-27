// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "0") ;

Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);                             
Console.WriteLine();
SortToLowerArray(array);  
Console.WriteLine();
PrintArray(array);                

//methods
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(min, max + 1);
            }
        }
    return result;
}

void PrintArray(int [,] InArray)
{
        for (int i = 0; i < InArray.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < InArray.GetLength(1); j++)
            {
            Console.Write(InArray[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
        }
}

void SortToLowerArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int temp = array[i, z + 1];
                    array[i, z + 1] = array[i, z];
                    array[i, z] = temp;
                }
            }
        }
    }
}


