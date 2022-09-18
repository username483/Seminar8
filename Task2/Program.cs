// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести 
// сообщение для пользователя.
Console.Clear();

Console.Write("количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine("Новый массив: ");
PrintArray(TransformationArray(array));

int[,] TransformationArray(int[,] filledArray)
{
    int[,] transformationArray = new int[rows, columns];
    if (rows == columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transformationArray[i, j] = filledArray[j, i];

            }

        }
    }
    else
    {
        Console.WriteLine("Ошибка");
        return new int [0,0];
    }
    return transformationArray;
}



int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }

    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            Console.Write(filledArray[i, j] + " ");
        }
        Console.WriteLine();
    }

}
