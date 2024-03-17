/*Ex 1
Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile m, n.
Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la tastaura.
 Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
 Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul.*/



Console.Write("Enter the number of rows for matrix 1: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns for matrix 1: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter elements for matrix 1:");
int[,] matrix1 = ReadMatrix(rows1, columns1);

Console.Write("Enter the number of rows for matrix 2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns for matrix 2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter elements for matrix 2:");
int[,] matrix2 = ReadMatrix(rows2, columns2);

Console.WriteLine("\nMatrix 1:");
PrintMatrix(matrix1);
Console.WriteLine("\nMatrix 2:");
PrintMatrix(matrix2);


Console.WriteLine("\nResult of addition:");
int[,] result = AddMatrices(matrix1, matrix2);
if (result != null)
{
    PrintMatrix(result);
}

static int[,] ReadMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Enter element at position ({i},{j}): ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matrix;
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    if (rows1 != rows2 || columns1 != columns2)
    {
        Console.WriteLine("Matrices must have the same dimensions.");
        return null;
    }
    int[,] result = new int[rows1, columns1];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    return result;
}

    