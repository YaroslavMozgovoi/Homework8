// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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


int[] SumNumberRous(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int sum = 0;
    int j = 0;
    while (j < matrix.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum = sum + matrix[j, i];
        }
        array[j] = sum;
        j++;
        sum = 0;
    }
    return array;
}

void PrintArray(int[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 1) Console.Write($"{newArray[i],3}, ");
        else Console.Write($"{newArray[i],3} ");
    }
    Console.Write("]");
    Console.WriteLine("");
}

void PrintMinNumber(int[] array)
{
    int indexMinNumber = 0;
    int minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]< minNumber) 
        {
            indexMinNumber = i;
            minNumber = array[i];
        }
    }
    Console.WriteLine($"Наименьшую сумму чисел имеет {indexMinNumber + 1 } строка.");

}


int[,] matrix2DIntRandom = Matrix2DIntRandom(4, 3, -1, 23);
PrintMatrix(matrix2DIntRandom);
Console.WriteLine();

int[] sumNumberRous = SumNumberRous(matrix2DIntRandom);
PrintArray(sumNumberRous);
Console.WriteLine();

PrintMinNumber(sumNumberRous);