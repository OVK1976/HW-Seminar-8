/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int n = 4;
int[,] NewArray = new int[n, n];
FillArraySpiral(NewArray, n);
PrintArray(NewArray);


//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int number = 1;
    for (int nums = 0; nums < n * n; nums++)
    {
        int k = 0;
        while (k < n - 1)
        {
            array[i, j++] = number++;
            k++;
        }

        for (k = 0; k < n - 1; k++) array[i++, j] = number++;
        for (k = 0; k < n - 1; k++) array[i, j--] = number++;
        for (k = 0; k < n - 1; k++) array[i--, j] = number++;
        ++i; 
        ++j;
        if (n < 2)
        {
            n = 0;
        }
        else
        {
          n = n - 2;
        }
        
    }
}

# region Функция вывода двумерного массива на печать
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
#endregion