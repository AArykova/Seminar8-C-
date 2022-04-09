// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int lines = 3;
int columns = 4;
int[,] arrayA = new int[lines, columns];
int[,] arrayB = new int[lines, columns];
int[,] newarray = new int[lines, columns];
FillArray(arrayA, arrayB);
PrintArray(arrayA, arrayB);
Console.WriteLine();
CompositionArray();


void FillArray(int [,] array, int [,] array1)
{
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array1[i, j] = rand.Next(0, 10);
        }
    }
}
void PrintArray(int [,] array, int [,] array1)
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CompositionArray()
{
    
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newarray[i, j] = arrayA[i,j]*arrayB[i,j];
            Console.Write(newarray[i, j] + " ");
        }
         Console.WriteLine();
    }    
}
