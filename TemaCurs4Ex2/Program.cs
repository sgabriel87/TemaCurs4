/*Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k.
Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
 Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
 Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul. */


Console.Write("Enter the size of dimension 1 (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the size of dimension 2 (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the size of dimension 3 (k): ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter elements for the matrix:");
int[,,] matrix = ReadMatrix(n, m, k);

Console.WriteLine("\nMatrix elements:");
Console.WriteLine($"Sum of elements: {SumOfElements(matrix)}");
Console.WriteLine($"Maximum element: {MaxElement(matrix)}");


static int[,,] ReadMatrix(int n, int m, int k)
    {
        int[,,] matrix = new int[n, m, k];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                for (int l = 0; l < k; l++)
                {
                    Console.Write($"Enter element at position ({i},{j},{l}): ");
                    matrix[i, j, l] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        return matrix;
    }

    static int SumOfElements(int[,,] matrix)
    {
        int sum = 0;
        foreach (var element in matrix)
        {
            sum += element;
        }
        return sum;
    }

    static int MaxElement(int[,,] matrix)
    {
        int max = int.MinValue;
        foreach (var element in matrix)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }


    

