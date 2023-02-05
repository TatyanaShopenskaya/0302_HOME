// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите количество строк двумерного масссива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(rows, columns, 0, 9);
PrintMatrix(array2D);

Console.WriteLine("Введите позицию строки элемента");
int posI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца элемента");
int posJ = Convert.ToInt32(Console.ReadLine());

if (posI < 0 || (posI > array2D.GetLength(0) - 1) || posJ < 0 || (posJ > array2D.GetLength(1) - 1))
{
    Console.WriteLine("Такого элемента нет в массиве");
}
else
{
    Console.WriteLine($"Значение элемента массива на заданных позициях = {array2D[posI, posJ]}");
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}     ");
            else Console.WriteLine($"{matrix[i, j]}", 5);
        }
    }
}

