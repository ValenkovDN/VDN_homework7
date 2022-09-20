// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

void massiv()
{
int m = new Random().Next(5, 5);
int n = new Random().Next(5, 5);

double[,] table = new double[m,n];

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table[i,j] = new Random().Next(-20, 20);
    }
}

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write($"{table[i,j]}   ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое в кждом столбце:");
for (int j = 0; j < table.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        sum += table[i, j];
    }
    Console.Write($"{ Math.Round(sum / table.GetLength(0), 2)} ");
}
}
massiv();