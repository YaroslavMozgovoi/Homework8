// Задача 60.
//  ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



int[,,] Matrix3DIntRandom(int rous, int colum, int depth)
{
    int[,,] matrix = new int[rous, colum, depth];
    int min = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = min;
                min = min + 1;
            }
        }
    }
    return matrix;

}



void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k <  matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k],3}({i},{j},{k}) ");
            }
        }
        Console.WriteLine("|");
    }
}

 // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            // else Console.Write($"{matrix[i, j],4} ");

int [,,] matrix3DIntRandom = Matrix3DIntRandom(2,2,2);
Print3DMatrix(matrix3DIntRandom);