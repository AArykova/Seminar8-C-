// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выведет элементы и их индексы.

int lines = 3;
int columns = 5;
int depth = 3;
int[,,] array = new int[lines, columns, depth];
FillArray();
PrintArray();



void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = rand.Next(0, 10);
            }
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
