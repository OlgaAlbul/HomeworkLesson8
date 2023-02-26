//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
            array[i, j] = rnd.Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t ");
        }
        Console.WriteLine();

    }
}

int [] FindMinIndex (int [,] array)
{
    int [] index = new int [2];
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j]<min)
                {
                    min = array [i,j];
                    index[0] = i;
                    index[1] = j;
                }
            }
        }
    Console.WriteLine($"Минимальное число в массиве: {min}");
    return  index;
}

int [,] ResultMatrix (int [,] table, int [] array)
{
  int [,] resMatr = new int [table.GetLength(0)-1,table.GetLength(1)-1];
  int k = 0, l = 0;
  for (int i = 0; i < table.GetLength(0); i++)
  {
    for (int j = 0; j < table.GetLength(1); j++)
    {
      if (array[0] != i && array[1] != j)
      {
        resMatr[k, l] = table[i, j];
        l++;
      }
    }
    l = 0;
    if (array[0] != i)
    {
      k++;
    }
  }
  return resMatr;
}



int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of colomns: ");

int [,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
PrintArray(ResultMatrix(matrix, FindMinIndex(matrix)));











