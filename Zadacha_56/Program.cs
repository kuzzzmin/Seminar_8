/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }    
       
    }  
}    
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write(array[i, j] + "; ");
         }
         Console.WriteLine();
    }
}
int SearchMinSumStr(int[,] array)
{
    int MinSumStr = 0;
    int indexMinStr = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        MinSumStr = MinSumStr + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumStr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStr = sumStr + array[i, j];
        }
        if (sumStr < MinSumStr)
        {
            MinSumStr = sumStr;
            indexMinStr = i;
        }
    }
    return indexMinStr;
}

Console.WriteLine("Введите кол-во строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[x, y];

FillArray(array);
PrintArray(array);
int indexMinSumStr = SearchMinSumStr(array);
Console.WriteLine(indexMinSumStr);
