/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] nambers = new int[rows, columns];
FillMatrixRandomNumbers(nambers);
WriteMatrix(nambers);

int min = 0;
int minSum = 0;
int sum = 0;
for (int i = 0; i < nambers.GetLength(1); i++)
{
    min += nambers[0, i];
}
for (int i = 0; i < nambers.GetLength(0); i++)
{
    for (int j = 0; j < nambers.GetLength(1); j++) sum += nambers[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
}
Console.Write($"{minSum + 1} строка");

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void WriteMatrix(int[,] array)
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}