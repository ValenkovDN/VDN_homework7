// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.

void Massiv()
{
int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);

double[,] table = new double[m,n];

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table[i,j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(),2);
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
}
Massiv();