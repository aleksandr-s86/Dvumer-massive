/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
int[,]array = GetArray(rows,columns,0,10);
PrintArray(array);
WriteLine("Сумма каждой строки массива: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    int sumrow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumrow += array[i, j];
    }
    Write($"{sumrow} ");
}
WriteLine();
StingMinSum(array);


int[,]GetArray(int m,int n,int minValue, int maxValue)
{
    int[,]result = new int[m,n];
    for(int i=0;i<m; i++)
    {
        for(int j =0;j<n;j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}
void PrintArray(int[,]inArray)
{
    for(int i=0;i<inArray.GetLength(0);i++)
    {
        for(int j=0;j<inArray.GetLength(1);j++)
        {
            Write($"{inArray[i,j]} ");
        }
         WriteLine();
    }
}

void StingMinSum(int[,]inArray)
{
   int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        minRow += inArray[0, i];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) sumRow += inArray[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Write($"Строка с наименьшей сумммой элементов: {minSumRow + 1} строка");
}