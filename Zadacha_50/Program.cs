/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.*/

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
    Console.WriteLine();
}

Console.Write("Введите индекс строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[8, 8];
FillArray(numbers);
PrintArray(numbers);

if (n < numbers.GetLength(0) && m < numbers.GetLength(1)) Console.WriteLine(numbers[n, m]);
else Console.WriteLine($"{n}{m} -> такого числа НЕТ в нашем массиве");