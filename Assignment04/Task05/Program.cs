int n;

do {
    Console.WriteLine("Choose size of 2d array: 2 or 3");
    n = int.Parse(Console.ReadLine());
} while (n != 3 && n != 2);


int[,] arr = new int[n, n];
int ans;

Console.WriteLine("Enter elements of array");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = int.Parse(Console.ReadLine());
    }
}

if(n == 2)
{
    ans = arr[0,0] * arr[1,1] - arr[0,1] * arr[1,0];
}
else
{
    ans = arr[0,0] * (arr[1,1] * arr[2,2] - arr[1,2] * arr[2,1]) - arr[0,1] * (arr[1,0] * arr[2,2] - arr[1,2] * arr[2,0]) + arr[0,2] * (arr[1,0] * arr[2,1] - arr[1,1] * arr[2,0]);
}

Console.WriteLine("Determinant is: " + ans);