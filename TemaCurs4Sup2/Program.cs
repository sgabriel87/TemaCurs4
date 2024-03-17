/*Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz,
daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
cazurilor sa se afiseze numarul.*/

Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    switch (i)
    {
        case int n when n % 3 == 0 && n % 5 == 0:
            Console.WriteLine("FizzBuzz");
            break;
        case int n when n % 3 == 0:
            Console.WriteLine("Fizz");
            break;
        case int n when n % 5 == 0:
            Console.WriteLine("Buzz");
            break;
        default:
            Console.WriteLine(i);
            break;
    }
}