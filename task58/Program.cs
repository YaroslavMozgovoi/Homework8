// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Matrix2DIntRandom(int rous, int colum, int min, int max)
{
    int[,] matrix = new int[rous, colum];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}




void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
   int[,] matrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            matrix[i,j] += matrix1[i,k] * matrix2[k,j];
        }
    }
   }
   return matrix;
}


int[,] matrixA2DIntRandom = Matrix2DIntRandom(5, 4, -1, 23);
PrintMatrix(matrixA2DIntRandom);
Console.WriteLine();

int[,] matrixB2DIntRandom = Matrix2DIntRandom(4, 3, -1, 23);
PrintMatrix(matrixB2DIntRandom);
Console.WriteLine();

if( matrixA2DIntRandom.GetLength(1) == matrixB2DIntRandom.GetLength(0))
{
int[,] compositionMatrix = CompositionMatrix(matrixA2DIntRandom, matrixB2DIntRandom);
PrintMatrix(compositionMatrix);
}
else Console.WriteLine("Измените размер матриц");