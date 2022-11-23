/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
int[,] array = GetArrayRandom(3, 4);
PrintArray(array);
SredArithmetic(array, array.GetLength(0), array.GetLength(1));
int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 9)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SredArithmetic(int[,] array, int rows, int cols)
{
    double result = 0;
    double count = 0;
    double average = 0;
    for (int j = 0; j < cols; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            result = result + array[i, j];
            count++;
        }
        average = result / count;
        Console.Write($"{average} \t");
        result = 0;
        count = 0;
    }
    System.Console.WriteLine();
}
    

