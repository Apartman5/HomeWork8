// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

bool Labirint(int[,] array, int stp, int x, int y)
{
    switch (stp)
    {
        case 0:  
            y++;
            if (y >= array.GetLength(1))
            {
                return false;
            }
            break;
        case 1: 
            x++;
            if (x >= array.GetLength(0))
            {
                return false;
            }
            break;
        case 2:  
        y--;
            if (y < 0)
            {
                return false;
            }
            break;
        case 3: 
        x--;
            if (x < 0)
            {
                return false;
            }
            break;
    }
    return array[x, y] == 0;
}
void Step(int stp, ref int x, ref int y)
{
    switch (stp)
    {
        case 0:
            y++;
            break;
        case 1:
            x++;
            break;
        case 2:
            y--;
            break;
        case 3:
            x--;
            break;
    }
}

void OutputArray(int[,] matrix, string str)
{
    System.Console.WriteLine($"{str}:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:00} ");
        }
        Console.WriteLine();
    }
}

int n = 4;
int m = 4;
int x = 0;
int y = 0;
int stp = 0;
int[,] array = new int[n, m];

for (int i = 0; i < m * n; i++)
{
    array[x, y] = i + 1;
    if (Labirint(array, stp, x, y)== false)
    {
        stp++;
        if (stp == 4)
        {
            stp = 0;
        }
    }
    Step(stp, ref x, ref y);
}

OutputArray(array, "Спиральный массив");