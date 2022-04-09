// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int lines = 6;
int columns = 10;
int[,] array = new int[lines, columns];
FillArray();
PrintArray();
SummaArray();


void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
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
    };
}
void SummaArray()
{
    Console.WriteLine();
    int minsumma = lines*10;
    int minindex = 0;
    for (int i = 0; i < lines; i++)
    {
        int summa = 0;
        
        for (int j = 0; j < columns; j++)
        {
            summa += array[i, j];
        }
        if (summa < minsumma)
         {
            minsumma = summa;
            minindex = i;
         }
        Console.WriteLine($"Сумма в строке {i+1} равна {summa}");
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма в строках равна {minsumma} в {minindex+1} строке");
}
