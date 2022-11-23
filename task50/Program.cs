/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
int[,] array = GetArrayRandom(3, 4);
PrintArray(array);
Console.WriteLine ("Введите index строки:");
int indexRows = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите index столбца:");
int indexCols = int.Parse(Console.ReadLine()!);
indexArray(indexRows, indexCols, array, array.GetLength(0), array.GetLength(1));
int [,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 9)
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
       for (int j = 0; j <  array.GetLength(1); j++)
       {
        Console.Write(array[i, j] + " ");
       }
       Console.WriteLine(); 
    }
}
void indexArray(int rows, int cols, int[,]array, int rowsLength, int colsLength)
{
    if (rows < rowsLength && cols < colsLength)
    {
        Console.WriteLine ($"Значение в позиции [{rows}, {cols}] масcива : {array [rows, cols]}");
    }
    else
    {
        Console.WriteLine($"Нет в массиве позиции [{rows}, {cols}]");
    }
}
