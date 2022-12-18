using System.Runtime.CompilerServices;
Console.Write("Enter the first number: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("\nprime numbers from " + n1 + " to " + n2 + " are: ");

for (int i = n1; i <= n2; i++)
{
    int j;
    for (j = 2; j < i; j++)
    {
        if (i % j == 0)
            break;

    }
    if (i == j)
        Console.Write(i + " , ");
}
Console.WriteLine("\n");