// Изменение оформления
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Введите количество строк матрицы 1: ");
int rows1 = int. Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 1: ");
int columns1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите количество строк матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine());

int[,] FirstArray = new int[rows1, columns1];
int[,] SecondArray = new int[rows2, columns2];
int[,] ResultArray = new int[rows1, columns2];

FillArrayRandom(FirstArray);
Console.WriteLine("Получена первая матрица:");
PrintArray(FirstArray);
Console.WriteLine();
FillArrayRandom(SecondArray);
Console.WriteLine("Получена вторая матрица:");
PrintArray(SecondArray);
Console.WriteLine();


if (FirstArray.GetLength(0) != SecondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить.");
    return;
}
for (int i = 0; i < FirstArray.GetLength(0); i++)
{
    for (int j = 0; j < SecondArray.GetLength(1); j++)
    {
        ResultArray[i, j] = 0;
        for (int k = 0; k < FirstArray.GetLength(1); k++)
        {
            ResultArray[i, j] += FirstArray[i, k] * SecondArray[k, j];
        }
    }
}
Console.WriteLine("Результат умножения матриц:");
PrintArray(ResultArray);


// Функция заполнения массива рандомными числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}