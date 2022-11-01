/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Нахождение строки массива с наименьшей суммой элементов");
Console.WriteLine("Создан массив:");
int[,] Array = GetArray();
PrintSpace();
PrintArray(Array);
PrintSpace();
Console.WriteLine("Значения сумм элементов в каждой строке:");
int[] SRArray = SumRowArray(Array);
MinString(SRArray);
PrintSpace();


int[,] GetArray()
{
    int[,] array = new int[4, 6];
    Random rnd = new();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}   ");
        }
        Console.WriteLine();
    }

}
int [] SumRowArray (int[,] Array)
{
    int[] SumArray = new int[Array.GetLength(0)];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum += Array[i, j];
        }
        SumArray[i] = sum;
        Console.WriteLine($" {sum} ");
                
    }
    return SumArray;
}

void MinString (int[] array)
{
    
    int min = array[0];
    int MinIndexString=0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array [i]< min)
            {
            min = array [i];
            MinIndexString=i;
            }
        }  
    Console.WriteLine($"Минимальная сумма элементов находится в строке {MinIndexString+1}");
}

void PrintSpace()
{
    Console.WriteLine();
}