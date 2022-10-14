/* Задача 51: Задайте двумерный массив. Найдите
сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}
int ReleaseMatrix(int[,] matrix)
{
    int summaEl = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                summaEl += matrix[i, j];
        }
    }
    return summaEl;
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Ответ: {ReleaseMatrix(matrix)}");

/*
Задача про Деда Мороза

Console.Clear();

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i <= w; i+=x )
{
    for(int j = 0; j <= w; j+=y )
    {
        for(int k = 0; k <= w; k+=z )
        {
            if(i + j + k == w)
            {
                Console.WriteLine($"{i} {j} {k}");
                count++;
            }
        }
    }
}
Console.WriteLine(count);
*/
