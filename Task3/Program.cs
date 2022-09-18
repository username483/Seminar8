//  Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
Console.Clear();

Console.Write("количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine(String.Join(" ", FrequencyDictionary(array)));

int[] sortArray = FrequencyDictionary(array);
Array.Sort(sortArray);
PrintData(sortArray);

void PrintData(int[] sortArray)
{
    int el = sortArray[0];
    int count = 1;
    for (int i = 1; i < sortArray.Length; i++)
    {
        if (sortArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = sortArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}


int[] FrequencyDictionary(int[,] filledArray)
{
    int[] frequencyDictionary = new int[filledArray.GetLength(0) * filledArray.GetLength(1)];
    int count = 0;
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            frequencyDictionary[count] = filledArray[i, j];
            count++;
        }
    }
    return frequencyDictionary;
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
