Console.Clear();

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(1, 21);
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

Console.WriteLine("Введите размер массива: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[, ] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Введите номер строки и столбца массива: ");

int[] element = Console.ReadLine().Split().Select(x =>int.Parse(x)).ToArray();

if (element[0] <= matrix.GetLength(0) && element[1] <= matrix.GetLength(1))
Console.WriteLine(matrix[element[0] - 1, element[1] - 1]);
else
    Console.WriteLine("Элемента не существует");