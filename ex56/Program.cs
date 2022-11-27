// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "0") ;

Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);                             
Console.WriteLine(); 
SumRowsArray(array);
Console.WriteLine(); 
RowMinSum(array); 
Console.WriteLine(); 
              

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

void RowMinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow = minRow + array[0, i];
    }
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) sumRow = sumRow + array[i, j];
                    if (sumRow < minRow)
            {
                    minRow = sumRow;
                    minSumRow = i;
            }
                    sumRow = 0;
    }
    Console.Write($"номер строки с наименьшей суммой элементов => строка {minSumRow + 1} ");
}


void SumRowsArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum  = default;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"Сумма строки равна {sum}"); 
    }
}  


