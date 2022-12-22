/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого числа в массиве нет
*/

void PrintArray( /*const?*/ int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] +  " ");
        }
        Console.WriteLine();
    }

}


Console.WriteLine("введите первый индекс(a)");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второй индекс(b)");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[3,4] {
{11,22,33,44},
{61,78,83,91},
{10,11,12,13}
};

PrintArray(array);
Console.WriteLine();

if (a > array.GetLength(0)-1 || b > array.GetLength(1)-1)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine("значение элемента с индексом [a,b]: " + array[a,b]);
}

