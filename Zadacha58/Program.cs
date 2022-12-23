//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Колличество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колличество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int[rows, colums];
int[,] SecondMatrix = new int[rows, colums];
int[,] ResultMatrix = new int[rows, colums];

Fill2DArray(FirstMatrix);
Fill2DArray(SecondMatrix);
Print2DArray(FirstMatrix);
Console.WriteLine();
Print2DArray(SecondMatrix);

if (FirstMatrix.GetLength(0) != SecondMatrix.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
    }
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            ResultMatrix[i, j] = 0;
            for (int k = 0; k < FirstMatrix.GetLength(1); k++)
            {
                ResultMatrix[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
            }
        }
    }

Console.WriteLine("Результат умножения -");
Print2DArray(ResultMatrix);
