/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4
1 4 8 19
5 -2 33 -2
77 3 8 1*/

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);



/*Console.Clear();


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 10, 3);
}

double SearchMaxToArray(double[] array)
{
    double maxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxArray < array[i])
            maxArray = array[i];
    }
    return maxArray;
}

double SearchMinToArray(double[] array)
{
    double minArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minArray > array[i])
            minArray = array[i];
    }
    return minArray;
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимум и минимум: {SearchMaxToArray(array) - SearchMinToArray(array)}");
*/