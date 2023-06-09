Console.WriteLine("Enter length of array");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Console.WriteLine("Enter elements of array");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}



for (int i = 0; i < n - 1; i++)
{
    bool swp = false;
    for (int j = 0; j < n - i - 1; j++)
    {
        int tmp = 0;
        if (arr[j] > arr[j + 1])
        {
            tmp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = tmp;
            swp = true;
        }
    }
    if (!swp)
    {
        break;
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}