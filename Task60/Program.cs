/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся 
 двузначных чисел. Напишите программу, которая будет построчно 
 выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1) 
*/

Console.WriteLine("Вывод элементов трехмерного массива");
Console.WriteLine("Создан массив 2x2x2:");
int[,,] NewArray = GetArray();
PrintArray(NewArray);

int[,,] GetArray()
{
    int[,,] array = new int[2, 2, 2];
    Random rnd = new();
    for (int k = 0; k < 2; k++)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {

                {
                    array[i, j, k] = rnd.Next(1, 10);
                }
            }

        }   

    }
    return array;
}
void PrintArray(int[,,] array)
{

    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"  {array[i, j, k]} ({i}, {j}, {k})  ");
                }
                Console.WriteLine();
        }
         
    }
}