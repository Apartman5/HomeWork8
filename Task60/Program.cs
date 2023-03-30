// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool checkElement(int[,,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            {
                if (matrix[i, j, g] == number)
                {
                    return true;  
                }
            }
        }
    }
    return false;
}

Random rand = new Random();

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            {
                int a = rand.Next(10, 100);
                while (checkElement(matrix, a) == true)
                {
                    a = rand.Next(10, 100);
                }
                matrix[i, j, g] = a;
                Console.Write(matrix[i, j, g] + "("+i+","+j+","+g+")  ");
            }
            System.Console.WriteLine();
        }
         System.Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] numbers = Console.ReadLine().Split(" ");
int[,,] matrix = new int[n, n, n];
Console.WriteLine();
InputMatrix(matrix);

// задача решена с помощью наставника, затем полностью разобрана, осознана и принята к сведению)))