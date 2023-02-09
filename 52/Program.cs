// // // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // // Например, задан массив:
// // // 1 4 7 2
// // // 5 9 2 3
// // // 8 4 2 4
// // // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matr = CreateMatrixRndInt(rows, columns, 1, 9);
PrintMatrix(matr);
Console.WriteLine();
AverageColumns(matr);


//задаем двумерный массив
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


//выводим на печать двумерный массив
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

//метод поиска среднего арифмитического по столбцам
void AverageColumns(int[,] matrix)
{
    double sum = 0;    //double для дробных результатов
    for (int j = 0; j < matrix.GetLength(1); j++)    //проходим сначала по столбцам
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];     //суммируем элементы столбца 
        }
        Console.WriteLine($"{sum}/{matrix.GetLength(0)} => {Math.Round(sum / matrix.GetLength(0),1)}");    //выводим в консоль сразу среднее арифмитическое для каждого столбца+округление
        sum = 0;                         //обнуляем результаты перед вычислением для нового столбца
    }
}

