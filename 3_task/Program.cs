/*
Задача 3. Необязательная, дополнительная задача Задайте двумерный массив из 
трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, 
которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). 
Полученные средние арифметические занести в одномерный массив.

Например, задан массив:

100 404 504 225
550 478 800 363
505 101 410 479

=> [505, 252.5, 0, 363 ]
*/


void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(100, 999);
        }
    }
}


void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int rowCount = 10;
int columnCount = 10;
int[,] array = new int[rowCount, columnCount];


FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] array2 = new int[10];


for (int i = 0; i < array.GetLength(1); i++)
{
    int sum = 0;
    int a = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {

        if (array[j, i] % 10 == array[j, i] / 100)
        {
            sum = sum + array[j, i];
            a++;
        }

    }
    if (sum > 0)
    {
        array2[i] = sum / a;
        Console.Write(array2[i] + " ");
    }
    else
    {
        array2[i] = 0;
        Console.Write(array2[i] + " ");
    }
}

