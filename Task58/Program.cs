// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiMatrix (int[,] array1, int[,] array2)
{
    int[,] multArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if(array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Перемножить между собой можно матрицы, в которых количество столбцов первой равно количеству строк второй!");
    }
    else
    {   
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    multArray[i,j] += array1[i,k] * array2[k,j];
                }
                Console.Write(multArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    return multArray;
}

Console.WriteLine("Задайте параметры 1-й матрицы.");
int str1 = Prompt("Введите количество строк: ");
int col1 = Prompt("Введите количество столбцов: ");
int low1 = Prompt("Введите нижнюю границу перебора чисел: ");
int high1 = Prompt("Введите верхнюю границу перебора чисел: ");

Console.WriteLine("Задайте параметры 2-й матрицы.");
int str2 = Prompt("Введите количество строк: ");
int col2 = Prompt("Введите количество столбцов: ");
int low2 = Prompt("Введите нижнюю границу перебора чисел: ");
int high2 = Prompt("Введите верхнюю границу перебора чисел: ");

Console.WriteLine("1-я матрица: ");
int[,] firstArray = CreateArray(str1, col1, low1, high1);

Console.WriteLine("2-я матрица: ");
int[,] secondArray = CreateArray(str2, col2, low2, high2);

Console.WriteLine("Произведение матриц: ");
int[,] multArray = MultiMatrix(firstArray, secondArray);