/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}


void Averadge(int[,] matrix)
{
    double summaColumn = 0;
    double averageColumn = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        summaColumn += matrix[i, j];
        }
        averageColumn = summaColumn / matrix.GetLength(0);
        Console.Write($"Сумма {j + 1} столбца = {summaColumn} ");
        Console.WriteLine($" Среднеарифметическое = {averageColumn:F2}");
        summaColumn = 0;
    }   
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

InputMatrix(matrix);
Averadge(matrix);

