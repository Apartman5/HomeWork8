// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateArray(int m, int n, int l, int h)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(l, h);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void SortedArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] str = new int [array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str[j] = array[i,j];
        }
        Array.Sort(str);
        Array.Reverse(str);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = str[j];
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    } 
}

int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int low = Prompt("Введите нижнюю границу перебора чисел: ");
int high = Prompt("Введите верхнюю границу перебора чисел: ");

Console.WriteLine("Заданный массив: ");
int[,] specifiedArray = CreateArray(str, col, low, high);

Console.WriteLine("Отсортированный массив: ");
SortedArray(specifiedArray);