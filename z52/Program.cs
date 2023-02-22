Console.Clear();

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(1, 20);
    }
}


void PrintMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void SumcolMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        sum = sum + matrix[j, i];
        sum = sum / matrix.GetLength(0);
        Console.Write($"{sum} \t");
    }
    
}


Console.WriteLine("Введите размер массива: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[, ] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
SumcolMatrix(matrix);

