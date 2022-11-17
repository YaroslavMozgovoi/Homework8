// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixSortingRows(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                if (matrix[k, i] < matrix[k, i + 1])
                {
                    int numb = matrix[k, i + 1];
                    matrix[k, i + 1] = matrix[k, i];
                    matrix[k, i] = numb;
                }


            }
        }
    }


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

int[,] matrix2DIntRandom = Matrix2DIntRandom(9, 7, -1, 23);
PrintMatrix(matrix2DIntRandom);
MatrixSortingRows(matrix2DIntRandom);
Console.WriteLine();
PrintMatrix(matrix2DIntRandom);