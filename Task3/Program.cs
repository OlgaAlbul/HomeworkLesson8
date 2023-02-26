//Сформировать трехмерный массив не повторяющимися двузначными числами
//показать его построчно на экран выводя индексы соответствующего элемента.
int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
                int number = 0;
                array[i, j, k] = rnd.Next(0,100);
                if (array[i,j,k] == number)
                {
                   array[i, j, k] = rnd.Next(0,100); 
                   number = array[i,j,k];
                }
                
           } 
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(1); k++) 
           {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
           }
        }
        Console.WriteLine();

    }
}

int x = ReadInt("Enter the number of x: ");
int y = ReadInt("Enter the number of y: ");
int z = ReadInt("Enter the number of z: ");
int [,,] matrix3D = new int [x,y,z];
FillArray(matrix3D);
PrintArray(matrix3D);





