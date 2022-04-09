// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int lines = 3;
int columns = 5;
int[,] array = new int[lines,columns];
FillArray();
PrintArray();
SravnArray();


void FillArray()
{
  Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0,10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SravnArray()
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                int temp = array[i,j];
                if (array[i,j] > array[i,k])
                {
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray();
}