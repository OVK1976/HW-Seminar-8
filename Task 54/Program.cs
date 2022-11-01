/*Задача 54: Задайте двумерный массив. Напишите программу, 
 которая упорядочит по убыванию элементы 
 каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.WriteLine("Упорядочивание по убыванию каждой строки массива ");
Console.WriteLine("Задайте количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива");
int n = int.Parse(Console.ReadLine());
int[,] NewArray = GetArray(m,n);
Console.WriteLine("Создан массив:");
PrintTwoDimensialArray(NewArray);
SortRowTwoDimensialArray(NewArray);
Console.WriteLine();
Console.WriteLine("Строки массива отсортированы:");
PrintTwoDimensialArray(NewArray);
Console.WriteLine();


#region Создание двумерного массива со случайными целыми числами
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
#endregion


#region Сортировка строки двумерного массива по убыванию
void SortRowTwoDimensialArray(int[,] StrArray)
{
    int Min, MinI, MinJ, Temp;
    for (int m = 0; m < StrArray.GetLength(0); m++)
    {
        for (int k = 0; k < StrArray.GetLength(1); k++)
        {
            Min = StrArray[m,0];
            MinI = m;
            MinJ = 0;
            for (int i = 0; i < (StrArray.GetLength(1) - k); i++)
            {
                if (StrArray[m,i] < Min)
                {
                    Min = StrArray[m, i];
                    MinI = m;
                    MinJ = i;

                }

            }
            Temp = StrArray[m,(StrArray.GetLength(1) - 1 - k)];
            StrArray[m, (StrArray.GetLength(1) - 1 - k)] = StrArray[MinI, MinJ];
            StrArray[MinI, MinJ] = Temp;
        }


    }  
    
}

#endregion

#region Печать двумерного массива
void PrintTwoDimensialArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]}  ");
        }
        Console.WriteLine();
    }

}
#endregion