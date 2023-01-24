/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4​
1 7 -> такого числа в массиве нет */

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 4;
const int COLUMNS = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int ReadNumber(string message) 
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);

int iPos = ReadNumber("Введите индекс элемента по строке:");
int jPos = ReadNumber("Введите индекс элемента по столбцу:");

if (iPos < ROWS && jPos < COLUMNS) 
    {
        int element = resultMatrix[iPos, jPos];
        Console.WriteLine("Искомый элемент:" + element);
    }else{
        Console.WriteLine("Такого числа в массиве нет.");
    }