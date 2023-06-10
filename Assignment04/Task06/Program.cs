int N, M, K, L;

do
{
    Console.WriteLine("Enter dimensions of first array");
    N = int.Parse(Console.ReadLine());
    M = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter dimensions of second array");
    K = int.Parse(Console.ReadLine());
    L = int.Parse(Console.ReadLine());

    if(M != K)
    {
        Console.WriteLine("Number of columns in first array must equal number of rows in second");
    }
} while (M != K);

int[,] arr1 = new int[N,M];
int[,] arr2 = new int[K,L];


Console.WriteLine("Enter elements of first array");

for(int i = 0; i < N; i++)
{
    for(int j = 0; j < M; j++)
    {
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Enter elements of secon array");

for (int i = 0; i < K; i++)
{
    for (int j = 0; j < L; j++)
    {
        arr2[i, j] = int.Parse(Console.ReadLine());
    }
}

int[,] arr3 = new int[N,L];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < L; j++)
    {
        for (int c = 0; c < M; c++)
        {
            arr3[i, j] += arr1[i, c] * arr2[c, j];
        }
    }
}

for(int i = 0; i < N; i++)
{
    for (int j = 0; j < L; j++)
    {
        Console.Write(arr3[i, j] + " ");
    }
    Console.WriteLine();
}