// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5

int m = 0;
int n = 0;

int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int [,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array[i, j] = i + j;
       if (i%2 == 0 && j%2 == 0)
       {
            array [i, j] = array[i, j] * array[i, j];
       }
    }
}

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
