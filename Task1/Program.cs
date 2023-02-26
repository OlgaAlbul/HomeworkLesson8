// Напишите программу, которая будет находить произведение двух матриц.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();

    }
}

void CompositionMatrix (int[,] matrix, int[,] table)
{
    int [,] composition = new int[matrix.GetLength(0),table.GetLength(1)];
    if (matrix.GetLength(1) != table.GetLength(0))
    {
        Console.Write("Произведение матриц найти невозможно");
    
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                int sum = 0;
                for (int s = 0; s < matrix.GetLength(1); s++)
                {
                    sum += matrix[i,s]*table[s,j];
                }
                composition[i,j] = sum;
            }           
        } 
        Console.WriteLine("Результат перемножения матриц:");
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write($"{composition[i, j]} \t ");
            }  
        Console.WriteLine();
        }       
    } 
}

int m = ReadInt("Enter the number of rows first matrix: ");
int n = ReadInt("Enter the number of colomns first matrix: ");

int [,] firstMatrix = new int[m,n];

int k = ReadInt("Enter the number of rows second matrix: ");
int l = ReadInt("Enter the number of colomns second matrix: ");

int [,] secondMatrix = new int[k,l];
Console.WriteLine("Первая матрица:");
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица");
FillArray(secondMatrix);
PrintArray(secondMatrix);
CompositionMatrix( firstMatrix, secondMatrix);
