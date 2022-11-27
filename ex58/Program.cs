// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMatrix(int row, int columns, int min, int max)
{
    int[,] matrix = new int[row, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} ");
            else Console.Write($"{matrix[i, j],1} ");
        }
        //Console.Write("|");
    }
}

void MultiplyMatrix (int[,] matrix1, int[,] matrix2, int[,] newmatrix)
{
  for (int i = 0; i < newmatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newmatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum = sum + matrix1[i,k] * matrix2[k,j];
      }
      newmatrix[i,j] = sum;
    }
  }
}

Console.Clear();
Console.Write("Введите количество строк в первой матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов в первой матрице (оно же количество строк во второй матрице): ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов во второй матрице: ");
int k = int.Parse(Console.ReadLine() ?? "0");


int[,] matrix1 = GetMatrix(m, n, 0, 10);
int[,] matrix2 = GetMatrix(n, k, 0, 10);
Console.Write($"первая матрица: ");
PrintMatrix(matrix1);
Console.WriteLine();
Console.Write($"вторая матрица: ");
PrintMatrix(matrix2);
Console.WriteLine();

int[,] newmatrix = new int[m, k];

MultiplyMatrix(matrix1, matrix2, newmatrix);
Console.WriteLine($"произведение двух матриц: ");
PrintMatrix(newmatrix);
Console.WriteLine();



