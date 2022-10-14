/*  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
    вещественными числами.
    m = 3, n = 4.
    0,5      7       -2    -0,2
    1       -3,3      8    -9,9
    8        7,8     -7,1   9*/

Console.Clear();


void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random rand = new Random();
            matrix[i, j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 3); //Math.Round ( ,3) - выводит 3 знака из вещественного числа
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);
