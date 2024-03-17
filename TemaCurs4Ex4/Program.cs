/*Scrieti o functie care pentru un numar “n” primit ca parametru, va afisa
urmatoarea piramida a numerelor:
1
2 2
3 3 3
4 4 4 4*/

Console.Write("Enter the number of rows for the number pyramid: ");
int numRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number pyramid ->");
PrintNumberPyramid(numRows);
static void PrintNumberPyramid(int n)
{
    foreach (int i in Enumerable.Range(1, n))
    {
        foreach (int j in Enumerable.Range(1, i))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

