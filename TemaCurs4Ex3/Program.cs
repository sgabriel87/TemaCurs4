/*Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m,
respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata*/


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


Console.WriteLine("\nResult of matrix multiplication:");
int[,] result = MultiplyMatrices(matrix1, matrix2);
if (result != null)
{
    PrintMatrix(result);
}
 int[,] ReadMatrix(int rows, int columns)
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

     void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        foreach (int element in matrix)
        {
            Console.Write(element + " ");
            if (--columns == 0)
            {
                Console.WriteLine();
                columns = matrix.GetLength(1);
            }
        }
    }

     int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);
        if (columns1 != rows2)
        {
            Console.WriteLine("Cannot multiply matrices. Inner dimensions don't match.");
            return null;
        }
        int[,] result = new int[rows1, columns2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                int sum = 0;
                foreach (int element in matrix1)
                {
                    sum += element * matrix2[i, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

   
        




