int m = 4;
int n = 4;

// int.TryParse(Console.ReadLine(), out m);
// int.TryParse(Console.ReadLine(), out n);

int [,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array[i, j] = new Random().Next(10);
    }
}

int sum1 = array[0,0] + array[1,1] + array[2,2] + array[3,3];
int sum2 = array[0,3] + array[1,2] + array[2,1] + array[3,0];


void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine(sum1);
Console.WriteLine(sum2);

