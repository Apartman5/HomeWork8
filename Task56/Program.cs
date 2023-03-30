// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
int low = Prompt("Введите нижнюю границу перебора чисел: ");
int high = Prompt("Введите верхнюю границу перебора чисел: ");

Console.WriteLine("Заданный массив: ");
int[,] specifiedArray = CreateArray(str, col, low, high);

int[] StringSum (int[,] array)
{
    int[] str = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        str[i] = sum; 
    }
    return str;
}
void SmallestSum (int[] array)
{
    int min = array[0];
    int indexMinNum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            indexMinNum = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в {indexMinNum + 1} строке");
}

int[] stringSum = StringSum(specifiedArray);
SmallestSum(stringSum);