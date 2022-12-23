// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j],3}\t");
        }
        Console.WriteLine();
    }
}

void GetMinSumRow(int[,] array)
{
    int MinRow = 0;
    int MinSumRow = 0;
    int SumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        MinRow = MinRow + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) SumRow = SumRow + array[i, j];
        if (SumRow < MinRow)
        {
            MinRow = SumRow;
            MinSumRow = i;
        }
        SumRow = 0;
    }
    Console.Write($"{MinSumRow + 1} строка");
}

Console.WriteLine("Колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колличество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[rows, colums];

Fill2DArray(table);
Print2DArray(table);
Console.WriteLine();
GetMinSumRow(table);