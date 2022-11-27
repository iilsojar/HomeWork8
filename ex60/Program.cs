//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите количество страниц в массиве: ");
int pages = int.Parse(Console.ReadLine() ?? "0") ;

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,,] array3D = GetArray(pages, columns, rows, 0, 100);
Console.WriteLine($"трехмерный массив: ");
PrintArray(array3D);
Console.WriteLine();

//methods
int[,,] GetArray(int p, int r, int c, int min, int max)
{
    int[,,] result = new int[p, r, c];
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < r; j++)
            {
                
                for (int k = 0; k < c; k++)
                {
                    result[i, j, k] = new Random().Next(min, max + 1);
                    int element = result[i, j, k];
                    int newelement = 0;
                    if (newelement == element)
                    break;
                    if (newelement != element)
                    element = newelement;
                }
            }
        }
    return result;
}

void PrintArray(int [,,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
        {
            Console.WriteLine("Page #" + (i +1));
            
            for (int j = 0; j < InArray.GetLength(1); j++)
            {
                for (int k = 0; k < InArray.GetLength(2); k++)
                {
                    Console.Write($"{InArray[i, j, k]} ");
                    Console.Write("({0},{1},{2})\t", i, j, k);;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
}
