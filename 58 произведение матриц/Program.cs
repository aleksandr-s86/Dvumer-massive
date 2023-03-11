/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
int[,]firstarray = new int[rows,columns];
int[,]secondarray = new int[rows,columns];
int[,]resultArray = new int[rows,columns];
FillArray(firstarray);
PrintArray(firstarray);
WriteLine();
FillArray(secondarray);
PrintArray(secondarray);
WriteLine();


for (int i = 0; i < firstarray.GetLength(0); i++)
{
    for (int j = 0; j < secondarray.GetLength(1); j++)
    {
        resultArray[i,j]=0;
        for (int k = 0; k < firstarray.GetLength(1); k++)
        {
            resultArray[i, j] += firstarray[i, k] * secondarray[k, j];
        }
    }
}
PrintArray(resultArray);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Write($"{array[i,j]} ");
        }
         WriteLine();
    }
}

