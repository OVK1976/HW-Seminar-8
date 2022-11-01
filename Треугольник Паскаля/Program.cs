/* Дополнительное задание.
Напишите программу выводящую треугольник Паскаля*/

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int n=int.Parse(Console.ReadLine());
for ( int k = 0; k < n; k++)
{
    for (int m = 0; m <= (n - k); m++)
    {       
            Console.Write("   ");        
    }
    for (int m = 0; m <= k; m++)
    {        
        Console.Write("     ");        
        Console.Write(factorial(k) / (factorial(m) * factorial(k - m)));
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.ReadLine();


#region Нахождение факториала

int factorial(int n)
{
    int F = 1;
    for ( int i = 1; i <= n; i++)
    {
        F *= i;
    }
    return F;
}
#endregion