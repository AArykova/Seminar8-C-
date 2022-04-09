// Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.

int lines = 4;
int columns = 4;
int[,] array = new int[lines,columns];
FillArray();
PrintArray();

void FillArray()
{
    int count = 1;
   // while (count < 16)
   // {
        for (int i = 0; i < lines; i++)
        {
        for (int j = 0; j < columns; j++)
        {
            //int count = 1; 
            //while (count < 16)
            //{
               array[i, j] = count; 
              count++;
            //}
        }
       // count++;
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