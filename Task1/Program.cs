// See Задайте двумерный массив. 
//Напишите программу, которая поменяет 
//местами первую и последнюю строку массива.

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
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transformationArray[i, j] = filledArray[rows - 1, j];

        }

    }

    for (int i = 1; i < rows - 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transformationArray[i, j] = filledArray[i, j];

        }

    }
    for (int i = rows - 1; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transformationArray[i, j] = filledArray[0, j];

        }

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
