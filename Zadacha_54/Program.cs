/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
 8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
            Console.Write(array[i, j] + " ");
        }    
       Console.WriteLine();
    }  
}    

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) -1; j++)
        {
            for (int t = 0; t < array.GetLength(1) - 1; t++)
            {
                int temp = 0;
                temp = array[i, t];
                array[i, t] = array[i, t + 1];
                array [i, t + 1] = temp;
            }
        }
    }
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

Console.WriteLine("Введите кол-во строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[x, y];

FillArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
